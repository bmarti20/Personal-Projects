#include <stdio.h>
#include <iostream>
#include <vector>
#include <string>
#include <thread>         // std::this_thread::sleep_for
#include <chrono>         // std::chrono::seconds
#include <windows.h>

using namespace std;

const int WIDTH  = 20;
const int HEIGHT = 10;

enum DIR {
    UP = 0,
    RIGHT,
    DOWN, 
    LEFT
};
uint8_t direction;

class Snake {
    public:
        typedef struct {
            int row;
            int col;
        } Position;

        vector<Position> tiles;
        uint8_t last_direction;
        Snake() {
            Position start;
            start.row = 1;
            start.col = 1;
            tiles.push_back(start);
            direction = RIGHT;
            last_direction = direction;
        }

        void travel() {
            // Ignore input if in opposite of travelling direction
            if ((direction == RIGHT && last_direction == LEFT) ||
                (direction == LEFT && last_direction == RIGHT) ||
                (direction == UP && last_direction == DOWN) ||
                (direction == DOWN && last_direction == UP)) {
                    direction = last_direction;
            }

            Position next;
            if (direction == RIGHT && tiles.back().col < WIDTH) {
                next = {tiles.back().row, tiles.back().col + 1};
            } else if (direction == LEFT && tiles.back().col > 0) {
                next = {tiles.back().row, tiles.back().col - 1};
            } else if (direction == UP && tiles.back().row > 0) {
                next = {tiles.back().row - 1, tiles.back().col};
            } else if (direction == DOWN && tiles.back().col < HEIGHT) {
                next = {tiles.back().row + 1, tiles.back().col};
            }
            tiles.push_back(next);
            tiles.erase(tiles.begin());

            last_direction = direction;
        }
};

void clear() {
    COORD topLeft  = { 0, 0 };
    HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);
    CONSOLE_SCREEN_BUFFER_INFO screen;
    DWORD written;

    GetConsoleScreenBufferInfo(console, &screen);
    FillConsoleOutputCharacterA(
        console, ' ', screen.dwSize.X * screen.dwSize.Y, topLeft, &written
    );
    FillConsoleOutputAttribute(
        console, FOREGROUND_GREEN | FOREGROUND_RED | FOREGROUND_BLUE,
        screen.dwSize.X * screen.dwSize.Y, topLeft, &written
    );
    SetConsoleCursorPosition(console, topLeft);
}

void draw_board() {
    Snake snake;

    while (true) {
        // clear();
        char board[HEIGHT][WIDTH] = {
            "___________________",
            "___________________",
            "___________________",
            "___________________",
            "___________________",
            "___________________",
            "___________________",
            "___________________",
            "___________________",
            "___________________"
        };
        for (int i = 0; i < 50; i++) cout << endl;
        // Replace snake tiles with x's
        for (int i = 0; i < snake.tiles.size(); i++) {
            board[snake.tiles[i].row][snake.tiles[i].col] = 'x';
        }

        // Print board
        for (int i = 0; i < HEIGHT; i++) {
            cout << board[i] << endl;
        }
        cout << endl;

        // Move snake
        snake.travel();

        this_thread::sleep_for (chrono::seconds(1));
    }
}

int main() {
    // Start thread for moving/drawing snake here
    thread drawing_thrd(draw_board);

    // Get inputs
    HANDLE hstdin;
    DWORD  mode;

    hstdin = GetStdHandle( STD_INPUT_HANDLE );
    GetConsoleMode( hstdin, &mode );
    SetConsoleMode( hstdin, ENABLE_ECHO_INPUT | ENABLE_PROCESSED_INPUT );  // see note below 
    
    while(true) {
        int ch = cin.get();
        switch (ch) {
            case 119: direction = UP; break;
            case 100: direction = RIGHT; break;
            case 115: direction = DOWN; break;
            case 97:  direction = LEFT; break;
            case 120: break;
        }
    }
    SetConsoleMode( hstdin, mode );
    drawing_thrd.join();

    return 0;
}
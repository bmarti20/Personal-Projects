#include <stdio.h>
#include <iostream>
#include <vector>
#include <algorithm> 
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

        Position food;
        vector<Position> tiles;
        uint8_t last_direction;
        Snake() {
            Position start = {1, 1};
            food = {1, 5};
            tiles.push_back(start);
            direction = RIGHT;
            last_direction = direction;
        }

        void generate_next_food() {
            vector<Position> empty_spaces;
            for (int row = 0; row < HEIGHT; row++) {
                for (int col = 0; col < WIDTH; col++) {
                    Position tile = {row, col};
                    bool match = false;
                    for (int i = 0; i < tiles.size(); i++) {
                        if (tiles[i].row == row && tiles[i].col == col) {
                            match = true;
                            break;
                        }
                    }
                    if (!match) empty_spaces.push_back(tile);
                }
            }
            food = empty_spaces[rand() % empty_spaces.size()];
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
            if (next.row == food.row && next.col == food.col) {
                generate_next_food();
            } else {
                tiles.erase(tiles.begin());
            }

            last_direction = direction;
        }
};

// void clear() {
//     COORD topLeft  = { 0, 0 };
//     HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);
//     CONSOLE_SCREEN_BUFFER_INFO screen;
//     DWORD written;

//     GetConsoleScreenBufferInfo(console, &screen);
//     FillConsoleOutputCharacterA(
//         console, ' ', screen.dwSize.X * screen.dwSize.Y, topLeft, &written
//     );
//     FillConsoleOutputAttribute(
//         console, FOREGROUND_GREEN | FOREGROUND_RED | FOREGROUND_BLUE,
//         screen.dwSize.X * screen.dwSize.Y, topLeft, &written
//     );
//     SetConsoleCursorPosition(console, topLeft);
// }

void draw_board() {
    Snake snake;
    char board[HEIGHT][WIDTH];
    while (true) {
        
        // Whitespace padding (fix this by clearing console?)
        for (int i = 0; i < 50; i++) cout << endl;

        // Fill board with blanks
        for (int row = 0; row < HEIGHT; row++) {
            for (int col = 0; col < WIDTH; col++) {
                board[row][col] = '_';
            }
        }

        // Draw snake tiles
        for (int i = 0; i < snake.tiles.size(); i++) {
            board[snake.tiles[i].row][snake.tiles[i].col] = 'x';
        }

        // Draw food
        board[snake.food.row][snake.food.col] = 'o';

        // Print board
        for (int row = 0; row < HEIGHT; row++) {
            for (int col = 0; col < WIDTH; col++) {
                cout << board[row][col];
            }
            cout << endl;
        }

        // Move snake
        snake.travel();

        this_thread::sleep_for(chrono::seconds(1));
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
#include <stdio.h>
#include <iostream>
#include <vector>
#include <string>
#include <thread>         // std::this_thread::sleep_for
#include <chrono>         // std::chrono::seconds

using namespace std;

const int WIDTH  = 20;
const int HEIGHT = 10;

class Snake {
    public:
        typedef struct {
            int row;
            int col;
        } Position;

        vector<Position> tiles;

        enum DIR {
            UP = 0,
            RIGHT,
            DOWN, 
            LEFT
        };
        uint8_t direction;

        Position next_block;

        Snake() {
            Position start = {1, 1};
            tiles.push_back(start);
            direction = RIGHT;

            next_block.row = 1;
            next_block.col = 5;
        }

        void travel() {
            if (direction == RIGHT && tiles.back().col < WIDTH) {
                Position next = {tiles.back().row, tiles.back().col + 1};
                tiles.push_back(next);
                if (next_block.col != next.col || next_block.row != next.row) 
                    tiles.erase(tiles.begin());
            }
        }
};

int main() {
    Snake snake;

    while (true) {
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
        
        // Replace snake tiles with x's
        for (int i = 0; i < snake.tiles.size(); i++) {
            board[snake.tiles[i].row][snake.tiles[i].col] = 'x';
        }

        // Print board
        for (int i = 0; i < HEIGHT; i++) {
            cout << board[i] << endl;
        }
        cout << endl;

        // Get keyboard input here

        // Move snake
        snake.travel();

        std::this_thread::sleep_for (std::chrono::seconds(1));
    }
    return 0;
}
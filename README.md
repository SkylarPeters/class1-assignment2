# Assignment 2 - Recursion to solve a maze

## Author

Skylar Peters

## Description

You must write a program to traverse a 12 x 12 maze and find a successful path from a starting point to an exit. You are given a hard coded maze in the program, as well as some starting coordinates.

Each spot in the maze is represented by either a '#' or a '.' (dot). The #'s represent the walls of the maze, and the dots represent paths through the maze. Moves can be made only up, down, left, or right (not diagonally), one spot at a time, and only over paths (not into or across a wall).

The exit will be any spot that is on the outside of the array. As your program attempts to find a path leading to the exit, it should place the character 'X' in each spot along the path. If a dead end is reached, your program should replace the X’s with 'O'. But, the spots with 'O' should be marked back to 'X' if these spots are part of a successful path leading to a final state.

The output of your program is the maze configuration after each move. In your testing, you may assume that each maze has a path from its starting point to its exit point. If there is no exit, you will arrive at the starting spot again.

In addition to solving the maze as is, I want you to also solve the transposition of the maze. There is a method stub in the main program for transposing the 2D array. This method is just that, a stub. You need to fill out the code to make that transpose method work. The program is already setup to solve both the original maze, and the transposed maze. Your program should be able to solve both of them without any issue.

You are required to use recursion to solve this problem.

Please remember to fill out this README file with the relevant information that is missing.

Make sure that you follow the documentation requirements described in assignments 0 and 1.

I also want you to comment the recursive method you implement thoroughly to show me that you know what is going on inside your method.

### Notes

It might be useful while developing this program to use a smaller sized maze, and then get it to work with the real ones.

Don't forget that you must have a base case for your recursive method or you will continue to get a stack overflow.

## Grading
| Feature             | Points |
|---------------------|--------|
| Solve Maze 1        | 15     |
| Solve Maze 2        | 15     |
| Transpose Maze      | 10     |
| Used Recursion      | 15     |
| README              | 5      |
| Documentation       | 5      |
| Places X's          | 10     |
| Places O's          | 10     |
| Prints Each Step    | 10     |
| Print Solved Result | 5      |
| **Total**           | **100**|

## Outside Resources Used

Used to help transpose: https://www.codegrepper.com/code-examples/csharp/c%23+transpose+2d+array

Used to help print the array: https://stackoverflow.com/questions/24094093/how-to-print-2d-array-to-console-in-c-sharp/31691625

Answer by Devrim A.(225 upvotes) helped to refresh my memory on using ref: https://stackoverflow.com/questions/748062/return-multiple-values-to-a-method-caller

Used to help pause the code after each print: https://www.codeproject.com/Questions/845104/How-to-pause-execution-of-Csharp-code-using-timer

## Known Problems, Issues, And/Or Errors in the Program

There might be a better way to organize or arrange the X and Y values in the recursive method, not sure.
All of the O's in a dead end appear at the same time when the next X is placed.
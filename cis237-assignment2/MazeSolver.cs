// Skylar Peters
// CIS 237
// 2/19/2021

using System;

namespace cis237_assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            // Do work needed to use mazeTraversal recursive call and solve the maze.
            // Starting values for x and y
            int X = xStart;
            int Y = yStart;
            // Bool passed by ref in order to stop recursion once a maze has been solved.
            bool stop = false;

            // Call the recursive method.
            mazeTraversal(maze, X, Y, ref stop);
        }

        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// More than likely you will need to pass in at a minimum the current position
        /// in X and Y maze coordinates. EX: mazeTraversal(int currentX, int currentY)
        /// 
        /// There might be a better/cleaner way to set up the X and Y values for
        /// this method, but I stopped messing with them when I got it to start working.
        /// </summary>
        private void mazeTraversal(char[,] maze, int currentY, int currentX, ref bool stop)
        {
            // Replace current position with X.
            maze[currentY, currentX] = char.Parse("X");

            // Display the maze in the console.
            PrintMaze(maze);

            // Check if exit is reached
            if (currentY == (maze.GetLength(0) - 1) || currentX == (maze.GetLength(1) - 1))
            {
                // When exit is reached, display that the maze has been solved(in green)
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The maze has been solved.");
                Console.ForegroundColor = ConsoleColor.White;

                // Also return stop as true in order to halt continued recursion.
                stop = true;
            }
            // If exit is not reached, move in possible directions.
            else
            {
                // Move left if possible and the exit has not been reached.
                if (maze[currentY, (currentX - 1)] == '.' && stop != true)
                {
                    // Call recursive method at new location.
                    mazeTraversal(maze, currentY, currentX - 1, ref stop);
                }

                // Move right if possible and the exit has not been reached.
                if (maze[currentY, (currentX + 1)] == '.' && stop != true)
                {
                    // Call recursive method at new location.
                    mazeTraversal(maze, currentY, currentX + 1, ref stop);
                }

                // Move up if possible and the exit has not been reached.
                if (maze[(currentY - 1), currentX] == '.' && stop != true)
                {
                    // Call recursive method at new location.
                    mazeTraversal(maze, currentY - 1, currentX, ref stop);
                }

                // Move down if possible and the exit has not been reached.
                if (maze[(currentY + 1), currentX] == '.' && stop != true)
                {
                    // Call recursive method at new location.
                    mazeTraversal(maze, currentY + 1, currentX, ref stop);
                }

                // Dead end. While going out of the dead end, replace X's with O's
                maze[currentY, currentX] = char.Parse("O");
            }
        }

        /// <summary>
        /// Method to print the maze in proper format.
        /// </summary>
        /// <param name="maze">Array that is being printed out</param>
        private void PrintMaze(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write(maze[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

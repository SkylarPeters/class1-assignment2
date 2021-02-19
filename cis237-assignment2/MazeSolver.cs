﻿using System;

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
            int X = xStart;
            int Y = yStart;
            bool stop = false;
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
            // Replace position with X
            maze[currentY, currentX] = char.Parse("X");

            // Display the maze
            PrintMaze(maze);

            // Check if exit is reached
            if (currentY == (maze.GetLength(0) - 1) || currentX == (maze.GetLength(1) - 1))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The maze has been solved.");
                Console.ForegroundColor = ConsoleColor.White;
                stop = true;
            }
            else
            {
                // Move left if possible
                if (maze[currentY, (currentX - 1)] == '.' && stop != true)
                {
                    mazeTraversal(maze, currentY, currentX - 1, ref stop);
                }

                // Move right if possible
                if (maze[currentY, (currentX + 1)] == '.' && stop != true)
                {
                    mazeTraversal(maze, currentY, currentX + 1, ref stop);
                }

                // Move up if possible
                if (maze[(currentY - 1), currentX] == '.' && stop != true)
                {
                    mazeTraversal(maze, currentY - 1, currentX, ref stop);
                }

                // Move down if possible
                if (maze[(currentY + 1), currentX] == '.' && stop != true)
                {
                    mazeTraversal(maze, currentY + 1, currentX, ref stop);
                }

                // Dead end/No path
                maze[currentY, currentX] = char.Parse("O");
            }
        }

        /// <summary>
        /// Method to print the maze
        /// </summary>
        /// <param name="maze"></param>
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

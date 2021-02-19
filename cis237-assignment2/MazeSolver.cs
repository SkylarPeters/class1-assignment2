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
            int X = xStart;
            int Y = yStart;
            mazeTraversal(maze, X, Y);
        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// More than likely you will need to pass in at a minimum the current position
        /// in X and Y maze coordinates. EX: mazeTraversal(int currentX, int currentY)
        /// </summary>
        private void mazeTraversal(char[,] maze, int currentX, int currentY)
        {
            // Implement maze traversal recursive call

            // Replace position with X
            maze[currentX, currentY] = char.Parse("X");

            // Display the maze
            PrintMaze(maze);

            // Check if exit is reached
            if (currentX == maze.GetLength(0) || currentY == maze.GetLength(1))
            {
                Console.WriteLine("The maze has been solved.");
            }

            // 
            if (maze[(currentX - 1), currentY] == '.')
            {
                mazeTraversal(maze, currentX - 1, currentY);
            }

            // 
            if (maze[(currentX + 1), currentY] == '.')
            {
                mazeTraversal(maze, currentX - 1, currentY);
            }

            // 
            if (maze[currentX, (currentY - 1)] == '.')
            {
                mazeTraversal(maze, currentX - 1, currentY);
            }

            // 
            if (maze[currentX, (currentY + 1)] == '.')
            {
                mazeTraversal(maze, currentX - 1, currentY);
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

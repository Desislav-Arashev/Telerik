using System;

namespace Matrix
{
    public class WalkInMatrix
    {
        
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int step = size;
            int count = 1;
            int row = 0;
            int col = 0;
            int directionX = 1;
            int directionY = 1;

            while (true)
            {
                matrix[row, col] = count;

                if (MatrixActions.CheckOutOfRange(matrix, row, col))
                {
                    count++;
                    break;
                }

                if (row + directionX >= size || row + directionX < 0 || col + directionY >= size || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                {
                    while (row + directionX >= size || row + directionX < 0 || col + directionY >= size || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                    {
                        MatrixActions.ChangeDirections(ref directionX, ref directionY);
                    }
                }

                row += directionX;
                col += directionY;
                count++;
            }

            MatrixActions.FindFirstEmpyCell(matrix, out row, out col);

            if (row != 0 && col != 0)
            {
                directionX = 1;
                directionY = 1;

                while (true)
                {
                    matrix[row, col] = count;
                    if (MatrixActions.CheckOutOfRange(matrix, row, col))
                    {
                        break;
                    }

                    if (row + directionX >= size || row + directionX < 0 || col + directionY >= size || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                    {
                        while (row + directionX >= size || row + directionX < 0 || col + directionY >= size || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                        {
                            MatrixActions.ChangeDirections(ref directionX, ref directionY);
                        }
                    }

                    row += directionX;
                    col += directionY;
                    count++;
                }
            }

            MatrixActions.PrintMatrix(size, matrix);
        }               
    }
}

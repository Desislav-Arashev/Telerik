using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    public static class MatrixActions
    {
        public static bool CheckOutOfRange(int[,] arr, int row, int col)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (row + dirX[i] >= arr.GetLength(0) || row + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (col + dirY[i] >= arr.GetLength(0) || col + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[row + dirX[i], col + dirY[i]] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void FindFirstEmpyCell(int[,] arr, out int row, out int col)
        {
            row = 0;
            col = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
        }

        public static void ChangeDirections(ref int directionX, ref int directionY)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;
            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == directionX && dirY[count] == directionY)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                directionX = dirX[0];
                directionY = dirY[0];
                return;
            }

            directionX = dirX[cd + 1];
            directionY = dirY[cd + 1];
        }

        public static void PrintMatrix(int size, int[,] matrix)
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write("{0,3}", matrix[r, c]);
                }

                Console.WriteLine();
            }
        }
    }
}

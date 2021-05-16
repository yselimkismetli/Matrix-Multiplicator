using System;

namespace Matrix_Multiplicator
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixFinalRow = 0;
            int matrixFinalCol = 0;
            int smallRow = 0;
            int smallCol = 0;
            Console.Write("Rows for Matrix A: ");
            int matrixARow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cols for Matrix A: ");
            int matrixACol = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rows for Matrix B: ");
            int matrixBRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cols for Matrix B: ");
            int matrixBCol = Convert.ToInt32(Console.ReadLine());
            int[,] matrixA = new int[matrixARow, matrixACol];
            int[,] matrixB = new int[matrixBRow, matrixBCol];
            Random randomNumber = new Random();
            for (int i = 0; i < matrixARow; i++)
            {
                for (int j = 0; j < matrixACol; j++)
                {
                    matrixA[i, j] += randomNumber.Next(0, 13);
                }
            }
            for (int i = 0; i < matrixBRow; i++)
            {
                for (int j = 0; j < matrixBCol; j++)
                {
                    matrixB[i, j] += randomNumber.Next(0, 13);
                }
            }
            if (matrixARow < matrixBRow)
            {
                matrixFinalRow = matrixARow;
            }
            else if (matrixARow > matrixBRow)
            {
                matrixFinalRow = matrixBRow;
            }
            else
            {
                matrixFinalRow = matrixARow;
            }
            smallRow = matrixFinalRow;
            if (matrixACol < matrixBCol)
            {
                matrixFinalCol = matrixACol;
            }
            else if (matrixACol > matrixBCol)
            {
                matrixFinalCol = matrixBCol;
            }
            else
            {
                matrixFinalCol = matrixACol;
            }
            smallCol = matrixFinalCol;
            Console.WriteLine("\n");
            int[,] matrixC = new int[smallRow, smallCol];
            for (int i = 0; i < smallRow; i++)
            {
                for (int j = 0; j < smallCol; j++)
                {
                    matrixC[i, j] = 0;
                    for (int k = 0; k < smallCol; k++)
                    {
                        matrixC[i, j] += (matrixA[i, k] * matrixB[k, j]);
                    }
                }
            }
            for (int i = 0; i < matrixFinalRow; i++)
            {
                for (int j = 0; j < matrixFinalCol; j++)
                {
                    Console.Write("{0}\t", matrixC[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

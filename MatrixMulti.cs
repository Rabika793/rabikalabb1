/*using System;


namespace lab11rabika
{
    internal class MatrixMulti
    {

        static void Main()
        {
            
            Console.Write("Enter the number of rows in the first matrix: ");
            int rowsA = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns in the first matrix (and rows in the second): ");
            int colsA = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns in the second matrix: ");
            int colsB = int.Parse(Console.ReadLine());

          
            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[colsA, colsB];
            int[,] resultMatrix = new int[rowsA, colsB];

            
            Console.WriteLine("Enter elements of the first matrix:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

           
            Console.WriteLine("Enter elements of the second matrix:");
            for (int i = 0; i < colsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            
            Console.WriteLine("Resultant Matrix:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}*/


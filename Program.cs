using System;

namespace cSharp_2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a 2D array of integers
            int[,] array2D = { { 5, 6, 10 }, { 9, 8, 4 } };
            //calculates the sum of all the elements in the array
            //Console.WriteLine("The sum of the array is: " + calculateTheSumOfAllElements(array2D));
            // Count the average for each row
            //Console.WriteLine("The average of each row in this array: ");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("The average value of row {0} is {1}", i + 1, findTheAverageOfEachRow(array2D));
            //}
            // Search for number

            //int[,] transposedArray = transposeMatrix(array2D);
            Console.WriteLine("Before transpose: "+array2D);
            Console.WriteLine("The transposed matrix is: ");
            Console.WriteLine("[" + String.Join(", ", transposeMatrix(array2D)) +"]");
        }


        //Example of 2d- Array
        //int[,] my2DArray = new int[3, 2];
        //my2DArray[0, 0] = 00;
        //my2DArray[0, 1] = 01;
        //my2DArray[1, 0] = 10;
        //my2DArray[1, 1] = 11;
        //my2DArray[2, 0] = 20;
        //my2DArray[2, 1] = 21;
        //Console.WriteLine(my2DArray.Length);
        //for (int i = 0; i < my2DArray.GetLength(0); i++) { 
        //    for (int j = 0; j < my2DArray.GetLength(1); j++)
        //    {
        //        Console.WriteLine(my2DArray[i, j]);
        //    }

        //}
        //// Example 2 of 2D Array
        //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

        //for (int i = 0; i < numbers.GetLength(0); i++)
        //{
        //    for (int j = 0; j < numbers.GetLength(1); j++)
        //    {
        //        Console.WriteLine(numbers[i, j]);
        //    }
        //}



        //Write a program that takes a 2D array of integers as input and calculates the sum of all the elements in the array. Display the sum as the output.
        //static int calculateTheSumOfAllElements(int[,] array2D)
        //{
        //    int sum = 0;

        //     First loop
        //    for (int row = 0; row < array2D.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < array2D.GetLength(1); col++)
        //        {
        //             Add the current element to the sum
        //            sum += array2D[row, col];
        //        }
        //    }
        //    return sum;
        //}

        //Write a program that takes a 2D array of integers as input and calculates the average value for each row. Display the average value of each row as the output.

        //static double findTheAverageOfEachRow(int[,] array2D)
        //{
        //    double average = 0;
        //    //First loop for row
        //    for (int row = 0; row < array2D.GetLength(0); row++)
        //    {
        //        double sum = 0;
        //        //Second loop for colm
        //        for (int col = 0; col < array2D.GetLength(1); col++)
        //        {
        //            //Add the current element to the sum
        //            sum += array2D[row, col];
        //            //count++; //Add count 
        //        }
        //        average = sum / array2D.GetLength(1);
        //        //Console.WriteLine("The average value of row {0} is {1}", row + 1, average);
        //    }
        //    return average;
        //}
        //Write a program that takes a 2D array of integers as input and a target number.
        //Search for the target number in the array and display its position(row and column)
        //if found.If the target number is not found, display a message indicating its absence.
        //static (int,int)? searchForAnElement(int[,] array2D, int target) //
        //{
        //    //Console.WriteLine(array2D);
        //    //First loop
        //    for (int row = 0; row < array2D.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < array2D.GetLength(1); col++)
        //        {
        //            if (array2D[row, col] == target)
        //            {
        //                 return (row + 1, col + 1);
        //            } 
        //        }
        //    }
        //    return null;
        //}

        //Write a program that takes a 2D array of integers as input and transposes the matrix.
        //Display the transposed matrix as the output. The transpose of a matrix swaps the elements' positions across the main diagonal.

        static int[,] transposeMatrix(int[,] array2D) 
        {
            int rows = array2D.GetLength(0);
            int cols = array2D.GetLength (1);
            int[,] transposed = new int[rows, cols];

            for (int row = 0; row < rows; row++) 
            {
                for (int col = 0; col < cols; col++)
                {
                    transposed[col,row] = array2D[row, col];
                }
            }
            return transposed;

        }

    }
}
    

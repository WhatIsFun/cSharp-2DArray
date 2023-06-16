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
            Console.WriteLine("The average of each row in this array: ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("The average value of row {0} is {1}", i + 1, findTheAverageOfEachRow(array2D));
            }
            //findTheAverageOfEachRow(array2D);

            // Search for number
            //Console.Write("Enter a target number: ");
            //int target = int.Parse(Console.ReadLine());

            // Call the search method and store the result
            //var result = searchForAnElement(array2D, target);

            // Check if the result is valid or not
            //if (result == (-1, -1))
            //{
            //    // Display a message if the target is not found
            //    Console.WriteLine("The target number {0} is not found in the array.", target);
            //}
            //else
            //{
            //    // Display the position of the target in the array
            //    Console.WriteLine("The target number {0} is found at row {1} and column {2} in the array.", target, result.Item1 + 1, result.Item2 + 1);

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

        static double findTheAverageOfEachRow(int[,] array2D)
        {
            double average = 0;
            //First loop for row
            for (int row = 0; row < array2D.GetLength(0); row++)
            {
                double sum = 0;
                //Second loop for colm
                for (int col = 0; col < array2D.GetLength(1); col++)
                {
                    //Add the current element to the sum
                    sum += array2D[row, col];
                    //count++; //Add count 
                }
                average = sum / array2D.GetLength(1);
                //Console.WriteLine("The average value of row {0} is {1}", row + 1, average);
            }
            return average;
        }
        //Write a program that takes a 2D array of integers as input and a target number.
        //Search for the target number in the array and display its position(row and column)
        //if found.If the target number is not found, display a message indicating its absence.
        //static int searchForAnElement(int[,] array2D, int target)
        //{
        //    Console.WriteLine(array[i]);
        //    First loop
        //    for (int row = 0; row < array2D.GetLength(0); row++)
        //    {


        //        for (int col = 0; col < array2D.GetLength(1); col++)
        //        {
        //            if (array2D[row, col] == target)
        //            {
        //                return (row, col);
        //            }

        //        }

        //    }
        //}
    }
    
}
    

namespace cSharp_2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculateTheSumOfAllElements();
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

            
        }
        //Write a program that takes a 2D array of integers as input and calculates the sum of all the elements in the array. Display the sum as the output.
        static void calculateTheSumOfAllElements()
        {
            // Declare a 2D array of integers
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Initialize a variable to store the sum
            int sum = 0;

            // Loop through the rows and columns of the array
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Add the current element to the sum
                    sum += array[i, j];
                }
            }

            // Display the sum as the output
            Console.WriteLine("The sum of all the elements in the array is " + sum);
        }
    }
}
    

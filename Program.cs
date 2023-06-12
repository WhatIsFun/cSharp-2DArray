namespace cSharp_2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculateTheSumOfAllElements();
            FindTheAverageOfEachRow();
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
            int[,] array = { { 5, 6, 10 }, { 9, 8, 4 } };

            int sum = 0;

            // First loop
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Add the current element to the sum
                    sum += array[i, j];
                }
            }

            // Display the sum
            Console.WriteLine("The sum of all the elements in the 2D-Array is " + sum);
        }

        //Write a program that takes a 2D array of integers as input and calculates the average value for each row. Display the average value of each row as the output.
        static void FindTheAverageOfEachRow()
        {
            int[,] array = { { 5, 6, 10 }, { 9, 8, 4 } };



            // First loop
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                int count = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Add the current element to the sum
                    sum += array[i, j];
                    count++; //Add count 
                }
                double average = (double)sum / count;
                // Display the average of each row 
                Console.WriteLine("The average of each row in the 2D-Array: ");
                Console.WriteLine("The average for row {0} is {1}", i + 1, average);
            }

        }
    }
    
}
    

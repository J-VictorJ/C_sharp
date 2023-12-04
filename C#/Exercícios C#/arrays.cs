using System;
using System.Linq;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. **Array Initialization:**
               Write a C# program that initializes an array of integers and then uses a loop to display each element of the array.*/
            
            int[] numbers = { 1, 2, 3, 74, 57, 16, 77, 98, 29, 10, 20, 77};


            //foreach (int num in numbers) {Console.WriteLine(num);}
            /*2. **Array Sum and Average:**
               Create a C# program that calculates the sum and average of elements in an array of integers using a loop.*/

            // int sum = 0;
            // double average = 0.0;
            // for(int i  = 0; i < numbers.Length; i+=1) { sum += numbers[i];   average = (double)sum / numbers.Length; }
            // Console.WriteLine(sum);
            //Console.WriteLine($"The average is: {average}");


            /*3. **Array Sorting:**
               Implement a C# program that sorts an array of integers in ascending order using the Array.Sort method and then displays the sorted array.*/

            //foreach (int number in numbers) { Array.Sort(numbers);Console.WriteLine(number); }


            /*4. **Reverse Array:**
               Write a C# program that reverses the elements of an array without using built-in methods or libraries.*/

            /*int[] reversedARR = new int[numbers.Length];   // criei um novo array
            
            for (int i = 0; i < numbers.Length; i++)
            {
                reversedARR[i] = numbers[numbers.Length - i - 1] ;
                Console.WriteLine(reversedARR[i]);
            }*/


            /*5. **Multi-dimensional Array:**
               Create a C# program that uses a multi-dimensional array to represent a 2D matrix. Populate the matrix with random numbers and display it.*/
            /*int[,] randdom = new int[8 , 8];
            Random random = new Random();
            for (int i = 0; i < randdom.GetLength(0); i++) { for (int j = 0; j < randdom.GetLength(1); j++) {randdom[i, j] = random.Next(10); }
            }
            for (int i = 0; i < randdom.GetLength(0); i++) { for (int j = 0; j < randdom.GetLength(0); i++) { Console.WriteLine(randdom[i, j] + " "); }
            }*/


            /*6. **Matrix Multiplication:**
               Implement a C# program that performs matrix multiplication for two given 2D matrices and displays the resulting matrix.*/

            /*int[,] matrixA = { { 2, 6 }, { 4, 12 } };
            int[,] matrixB = { { 4, 12 }, { 8, 24 } };

            int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            */

            /*7. **Jagged Array:**
               Write a C# program that uses a jagged array (an array of arrays) to store and display data about students and their exam scores.*/

            /*double[][] scores =
            {
                new double[] {8.1, 5.2, 7.3},
                new double[] {9.2, 10.4, 5.0},
                new double[] {10.0, 8.0, 10.0}
            };
            for (int i = 0; i < scores.Length; i++)
            {
                System.Console.WriteLine("Element 0:", i);
                for (int j = 0; j < scores[i].Length; j++)
                {
                    System.Console.WriteLine("{0}{1}", scores[i][j], j == (scores[i].Length - 1) ? "" : " ");
                }
            }*/

            /*8. **Find Maximum Element:**
               Develop a C# program that finds and displays the maximum element in an array of integers.*/

            //Console.WriteLine(numbers.Max());

            /*9. **Unique Elements:**
               Create a C# program that removes duplicate elements from an array and displays the unique elements.*/
            /*string [] numbers2 = { "1", "2", "3", "74", "57", "16", "74" };
            List<string> uniqueList = numbers2.Distinct().ToList();
            uniqueList.ForEach(i => Console.WriteLine($"{i}"));*/

            /*10. **3D Array:**
                Implement a C# program that works with a 3D array (a cube) to perform operations like summing the values of a diagonal or finding the minimum value.*/

                // Create a 3D array (a cube)
                int[,,] cube = new int[3, 3, 3]
                {
            { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
            { { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } },
            { { 19, 20, 21 }, { 22, 23, 24 }, { 25, 26, 27 } }
                };

                // Sum the values of the main diagonal
                int diagonalSum = 0;
                for (int i = 0; i < cube.GetLength(0); i++)
                {
                    diagonalSum += cube[i, i, i];
                }
                Console.WriteLine("Sum of the main diagonal: " + diagonalSum);

                // Find the minimum value in the cube
                int minValue = int.MaxValue;
                foreach (int value in cube)
                {
                    if (value < minValue)
                    {
                        minValue = value;
                    }
                }
                Console.WriteLine("Minimum value in the cube: " + minValue);
            }
        }

    }

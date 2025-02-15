using System;

namespace PracticeApp04
{
    class Program
    {
        static void OneDimArray()
        {
            int[] salaries = new int[5];

            salaries[0] = 50000;
            salaries[1] = 45000;
            salaries[2] = 30000;
            salaries[3] = 70000;
            salaries[4] = 55000;

            DisplayOneDimArray(salaries);
        }

        static void DisplayOneDimArray(int[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }

        static void TwoDimArray()
        {
            int[,] salariesPerYear = new int[5, 3];

            salariesPerYear[0, 0] = 54;
            salariesPerYear[0, 1] = 70;
            salariesPerYear[0, 2] = 80;

            salariesPerYear[1, 0] = 51;
            salariesPerYear[1, 1] = 67;
            salariesPerYear[1, 2] = 86;

            salariesPerYear[2, 0] = 64;
            salariesPerYear[2, 1] = 62;
            salariesPerYear[2, 2] = 76;

            salariesPerYear[3, 0] = 62;
            salariesPerYear[3, 1] = 68;
            salariesPerYear[3, 2] = 82;

            salariesPerYear[4, 0] = 52;
            salariesPerYear[4, 1] = 65;
            salariesPerYear[4, 2] = 61;

            DisplayTwoDimArray(salariesPerYear);
        }

        static void DisplayTwoDimArray(int[,] array)
        {
            for (int i = 0; i <= array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= array.GetLength(1) - 1; j++)
                {
                    Console.Write($"{array[i,j]} \t");
                }
                Console.WriteLine();
            }
        }

        static void ThreeDimArray()
        {
            int[,,] salariesPerYearPerDivision = new int[2, 4, 3];

            salariesPerYearPerDivision[0, 0, 0] = 55;
            salariesPerYearPerDivision[0, 0, 1] = 70;
            salariesPerYearPerDivision[0, 0, 2] = 80;

            salariesPerYearPerDivision[0, 1, 0] = 62;
            salariesPerYearPerDivision[0, 1, 1] = 67;
            salariesPerYearPerDivision[0, 1, 2] = 91;

            salariesPerYearPerDivision[0, 2, 0] = 64;
            salariesPerYearPerDivision[0, 2, 1] = 75;
            salariesPerYearPerDivision[0, 2, 2] = 93;

            salariesPerYearPerDivision[0, 3, 0] = 61;
            salariesPerYearPerDivision[0, 3, 1] = 83;
            salariesPerYearPerDivision[0, 3, 2] = 88;

            salariesPerYearPerDivision[1, 0, 0] = 52;
            salariesPerYearPerDivision[1, 0, 1] = 70;
            salariesPerYearPerDivision[1, 0, 2] = 80;

            salariesPerYearPerDivision[1, 1, 0] = 67;
            salariesPerYearPerDivision[1, 1, 1] = 73;
            salariesPerYearPerDivision[1, 1, 2] = 90;

            salariesPerYearPerDivision[1, 2, 0] = 64;
            salariesPerYearPerDivision[1, 2, 1] = 73;
            salariesPerYearPerDivision[1, 2, 2] = 93;

            salariesPerYearPerDivision[1, 3, 0] = 55;
            salariesPerYearPerDivision[1, 3, 1] = 68;
            salariesPerYearPerDivision[1, 3, 2] = 85;

            DisplayThreeDimArray(salariesPerYearPerDivision);
        }

        static void DisplayThreeDimArray(int[,,] array)
        {
            for (int i = 0; i <= array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= array.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k <= array.GetLength(2) - 1; k++)
                    {
                        Console.Write($"{array[i, j, k]} \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
            }
        }

        static void JaggedArray()
        {
            int[][] salariesPerYearPerDivision = new int[4][];

            salariesPerYearPerDivision[0] = new int[3] { 50, 70, 54 };
            salariesPerYearPerDivision[1] = new int[2] { 77, 65 };
            salariesPerYearPerDivision[2] = new int[2] { 50, 70 };
            salariesPerYearPerDivision[3] = new int[1] { 75 };

            DisplayjaggedArray(salariesPerYearPerDivision);
        }

        static void DisplayjaggedArray(int[][] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = 0; j <= array[i].Length - 1; j++)
                {
                    Console.Write($"{array[i][j]} \t");
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            OneDimArray();

            Console.WriteLine("----------------------------");

            TwoDimArray();

            Console.WriteLine("----------------------------");

            ThreeDimArray();

            Console.WriteLine("----------------------------");

            JaggedArray();
        }
    }
}

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void HandleMultipleExceptions(string numberString, int index)
        {
            int[] numbers = { 1, 2, 3 };

            try
            {
                int number = int.Parse(numberString);
                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}

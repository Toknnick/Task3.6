using System;

namespace Task3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxNumbersInArray = 100;
            int minNumbersInArray = 10;
            int maxValueInArray = 100;
            int numbersInArray = random.Next(minNumbersInArray, maxNumbersInArray);
            int[] arrayOfNumbers = new int[numbersInArray];
            int number = 0;
            Console.WriteLine("Массив:");

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(maxValueInArray);
                Console.Write(arrayOfNumbers[i] + ",");
            }

            for (int i = 0; i < numbersInArray; i++)
                for (int j = 0; j < numbersInArray; j++)
                    if (arrayOfNumbers[i] < arrayOfNumbers[j])
                    {
                        number = arrayOfNumbers[i];
                        arrayOfNumbers[i] = arrayOfNumbers[j];
                        arrayOfNumbers[j] = number;
                    }

            Console.WriteLine("\nМассив по возрастанию:");

            for(int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + ",");
            }
        }
    }
}

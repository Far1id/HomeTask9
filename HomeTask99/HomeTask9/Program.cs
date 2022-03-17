using System;

namespace HomeTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int FindIndex(string str, char ch)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==ch)
                {
                   
                    return i;
                }
            }
            return -1;
        }
        static int FindRoot(int number)
        {
            int root = 0;
            for (int i = 1; i*i < number; i++)
            {
                root = i;
            }
            return root;
        }
        static int SumOfNumbers(int number)
        {
            int sum = 0;
            int k = number;
            while (k>=1)
            {
                sum += k % 10;
                k = k / 10;
            }
            return sum;
        }
        static int MaxValue(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= max)
                    max = numbers[i];
            }
            return max;
        }
        static int PositiveValue(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    numbers[i] *= -1;
            }

            return numbers[];
        }
    }
}

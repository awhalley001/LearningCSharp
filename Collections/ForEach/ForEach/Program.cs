using System;

namespace ForEach
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i * 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine($"Element {j} = {nums[j]}");
            }
            
            // foreach loop
            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine($"Element {counter} = {k}");
                counter++;
            }
            

        }
    }
}
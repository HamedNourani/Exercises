using System;

namespace Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MainProcedure();
        }

        private static void MainProcedure()
        {
            try
            {
                Console.Write("Please enter a number to calculate its fibonacci: ");
                
                var inputNumber = int.Parse(Console.ReadLine());
                
                if (inputNumber < 0)
                {
                    HandleException();
                }
                
                var fibonacci =CalculateFibonacci(inputNumber);
                
                Console.WriteLine($"Fibonacci({inputNumber}) = {fibonacci}");
            }
            catch
            {
                HandleException();
            }
        }
        
        private static void HandleException()
        {
            Console.Clear();
            Console.WriteLine($"Invalid input! Please enter an integer number greater than or equal to 0.");
            MainProcedure();
            return;
        }
        
        private static long CalculateFibonacci(int inputNumber)
        {
            long[] memo = new long[inputNumber + 1];
            
            return CalculateFibonacciDynamically(inputNumber, memo);
        }

        private static long CalculateFibonacciDynamically(int n, long[] memo)
        {
            if (memo[n] != 0)
            {
                return memo[n];
            }
            
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                long fibonacci = CalculateFibonacciDynamically(n - 1, memo) + CalculateFibonacciDynamically(n - 2, memo);
                
                memo[n] = fibonacci;
        
                return fibonacci;
            }
        }
    }
}
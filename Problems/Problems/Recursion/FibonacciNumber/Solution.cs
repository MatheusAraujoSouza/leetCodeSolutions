namespace Problems.Problems.Recursion.FibonacciNumber
{
    public class Solution
    {
        public int Fib(int n)
        {
            if(n == 1) return 1;
            if(n == 0) return 0;

            return Fib(n - 1) + Fib(n -2);
        }
    }
}

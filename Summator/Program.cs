namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal result = Summator.Sum(new decimal[] {1, 2, 3, 4, 5, 6 });

            if (result == 21)
            {
                Console.WriteLine("TestPass");
            }            
        }
    }
}
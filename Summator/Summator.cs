namespace Summator
{
    public class Summator
    {
        public decimal Sum(decimal[]arr) 
        {
            checked
            {
                // check-> checks if the current type decimal overflows, if it overflows it will cry OverflowException
                // aritmetic exception
                decimal sum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                return sum;
            }
        }

        public static decimal Average(decimal[]arr ) 
        {
            var summator = new Summator();
            decimal sum = summator.Sum(arr);

            return sum / arr.Length;
        }
    }
}

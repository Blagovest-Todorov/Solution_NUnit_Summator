namespace Summator
{
    public static class Summator
    {
        public static decimal Sum(params decimal[]arr) 
        {
            decimal sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}

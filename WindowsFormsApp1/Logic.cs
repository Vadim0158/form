namespace WindowsFormsApp1
{
    public class Logic
    {
        public static int FindMax(int number)
        {
            int max = 0;
            int i = 0;
            while (i < 3)
            {
                int a = number % 10;
                if (a > max)
                {
                    max = a;
                }
                i++;
                number /= 10;
            }
            return max;
        }
    }
}
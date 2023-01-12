namespace git2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static long Power(long y, int j)
        {
            if (j == 0)
            {
                return 1;
            }

            if (j % 2 == 0)
            {
                var r = Power(y, j / 2);
                return r * r;
            }
            else
            {
                return y * Power(y, j - 1);
            }
        }
        static int Kub(int a)
        {
            int dig = a * a * a;

            return dig;
        }
    }
}




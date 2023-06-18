namespace Generics5
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] Num = { 3.8F, 4.9F, 9.2F };

            float min = Num[0];

            for (int i = 1; i < Num.Length; i++)
            {
                if (Num[1] < min)
                {
                    min = Num[i];
                }

            }
            Console.WriteLine("Minimum number is " + min);
        }
    }
}
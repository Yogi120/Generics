namespace Generics4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 4 };
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[1] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine("Minimum num " + min);
        }
    }
}
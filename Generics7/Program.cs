
namespace Generics7
{

    public class programm
    {
        static void Main(string[] args)
        {
            int num1 = 4, num2 = 2, num3 = 5;

            MinimumFinder<int> minimumfind = new MinimumFinder<int>();
            int min = minimumfind.FindMinimum(num1, num2, num3);


            Console.WriteLine(min);
        }

    }
}
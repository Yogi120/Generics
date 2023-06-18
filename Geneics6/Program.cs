namespace Geneics6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "cars", "bikes", "trains" };

            string min = str[0];

            for(int i = 1; i<str.Length; i++)
            {
                if (string.Compare(str[i], min) < 0)
                {
                    min = str[i];
                }
            }
            Console.WriteLine("minimum string is " + min);
        }
    }
}
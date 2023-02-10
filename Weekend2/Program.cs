
namespace Week_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int myVar = 7;

            int numb1 = -1 + 4 * myVar;
            Console.WriteLine(numb1);

            int numb2 = (35 + 5) % myVar;
            Console.WriteLine(numb2);

            int numb3 = 14 + -4 * 6 / 12;
            Console.WriteLine(numb3);

            int numb4 = 2 + 12 / 6 * 1 - myVar % 2;
            Console.WriteLine(numb4);
            int numb5 = myVar * myVar;

            if (numb5 > 10)
            {
                Console.WriteLine("myVar is greater than 4");
            }

            else
            {
                Console.WriteLine("myVar is less than 4");
            }
        }
    }
}
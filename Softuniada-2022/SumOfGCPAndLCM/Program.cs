namespace SumOfGCPAndLCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            //Find the max common devider
            int maxCommonDevider = firstNumber >= secondNumber ? secondNumber : firstNumber;
            while (maxCommonDevider > 1)
            {
                if (firstNumber % maxCommonDevider == 0 && secondNumber % maxCommonDevider == 0)
                {
                    break;
                }
                maxCommonDevider--;
            }

            //Find the min multiple
            int minMultiple = firstNumber >= secondNumber ? firstNumber : secondNumber;
            while (minMultiple <= int.MaxValue)
            {
                if (minMultiple % firstNumber == 0 && minMultiple % secondNumber == 0)
                {
                    break;
                }
                minMultiple++;
            }

            Console.WriteLine(maxCommonDevider + minMultiple);
        }
    }
}
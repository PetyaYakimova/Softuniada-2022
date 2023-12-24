using System.Globalization;

namespace CoffeeCups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string cupText = Console.ReadLine().ToUpper();

            //Smoke of the cup
            List<char> lineChars = new List<char>();
            for (int i = 0; i < inputNumber; i++)
            {
                lineChars.Add(' ');
            }
            for (int i = 0; i < 3; i++)
            {
                lineChars.Add('~');
                lineChars.Add(' ');
            }

            for (int i = 0; i < inputNumber; i++)
            {
                Console.WriteLine(string.Join("", lineChars));
            }

            //Top rim of the cup
            string rim = new string('=', (3 * inputNumber + 5));
            Console.WriteLine(rim);

            // Body of the cup
            lineChars.Clear();
            lineChars.Add('|');
            for (int i = 0; i < 2 * inputNumber + 4; i++)
            {
                lineChars.Add('~');
            }
            lineChars.Add('|');
            for (int i = 0; i < inputNumber - 1; i++)
            {
                lineChars.Add(' ');
            }
            lineChars.Add('|');
            string cupBodyLine = string.Join("", lineChars);

            for (int i = 1; i <= Math.Ceiling(((double)inputNumber - 3) / 2); i++)
            {
                Console.WriteLine(cupBodyLine);
            }

            lineChars.Clear();
            lineChars.Add('|');
            for (int i = 0; i < (2 * inputNumber + 4 - cupText.Length) / 2; i++)
            {
                lineChars.Add('~');
            }
            for (int i = 0; i < cupText.Length; i++)
            {
                lineChars.Add(cupText[i]);
            }
            for (int i = 0; i < (2 * inputNumber + 4 - cupText.Length) / 2; i++)
            {
                lineChars.Add('~');
            }
            lineChars.Add('|');
            for (int i = 0; i < inputNumber - 1; i++)
            {
                lineChars.Add(' ');
            }
            lineChars.Add('|');
            Console.WriteLine(string.Join("", lineChars));

            for (int i = 1; i <= Math.Floor(((double)inputNumber - 3) / 2); i++)
            {
                Console.WriteLine(cupBodyLine);
            }

            //Bottom rim of the cup
            Console.WriteLine(rim);

            //Bottom of the cup
            lineChars.Clear();
            for (int i = 0; i < inputNumber; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    lineChars.Add(' ');
                }
                lineChars.Add('\\');
                for (int j = 0; j < 2 * inputNumber + 4 - (2 * i); j++)
                {
                    lineChars.Add('@');
                }
                lineChars.Add('/');

                Console.WriteLine(string.Join("", lineChars));
                lineChars.Clear();
            }

            //Final line
            Console.WriteLine(new string('-', 3 * inputNumber + 5));
        }
    }
}
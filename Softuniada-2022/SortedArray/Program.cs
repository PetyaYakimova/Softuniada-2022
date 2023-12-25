namespace SortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arrayLength - 1; i++)
            {
                if ((i % 2 == 0 && inputArray[i] < inputArray[i + 1]) || (i % 2 != 0 && inputArray[i] > inputArray[i + 1]))
                {
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[i + 1];
                    inputArray[i + 1] = temp;
                }
            }

            Console.WriteLine(string.Join(' ', inputArray));
        }
    }
}
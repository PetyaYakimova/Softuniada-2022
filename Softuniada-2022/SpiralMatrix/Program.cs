namespace SpiralMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get the input
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] currentRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            //Will go through the matrix in circles as each circle goes through all 4 sides
            int circleNumber = 0;
            bool hasBeenIn = false;
            while (circleNumber < Math.Ceiling((double)rows / 2))
            {
                for (int col = circleNumber; col < cols - circleNumber; col++)
                {
                    Console.Write(matrix[circleNumber, col] + " ");
                    hasBeenIn = true;
                }
                if (!hasBeenIn)
                {
                    break;
                }
                hasBeenIn = false;
                for (int row = circleNumber + 1; row < rows - circleNumber; row++)
                {
                    Console.Write(matrix[row, cols - 1 - circleNumber] + " ");
                    hasBeenIn = true;
                }
                if (!hasBeenIn)
                {
                    break;
                }
                hasBeenIn = false;
                for (int col = cols - circleNumber - 2; col >= circleNumber; col--)
                {
                    Console.Write(matrix[rows - circleNumber - 1, col] + " ");
                    hasBeenIn = true;
                }
                if (!hasBeenIn)
                {
                    break;
                }
                hasBeenIn = false;
                for (int row = rows - circleNumber - 2; row > circleNumber; row--)
                {
                    Console.Write(matrix[row, circleNumber] + " ");
                }
                circleNumber++;
            }

            Console.WriteLine();
        }
    }
}
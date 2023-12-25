namespace HappyThreeFriends
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrderedWineCaskets = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOrderedWineCaskets; i++)
            {
                int[] wineBottlesPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (IsSplittingBottlesSuccessfull(wineBottlesPrices))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }

        public static bool IsSplittingBottlesSuccessfull(int[] wineBottles)
        {
            int sum = wineBottles.Sum();
            if (sum % 3 != 0)
            {
                return false;
            }

            int eachPersonShare = sum / 3;
            if (wineBottles.Any(w => w > eachPersonShare))
            {
                return false;
            }

            List<int> orderedWineBottleByPrice = wineBottles.OrderByDescending(w => w).ToList();
            int successfullCombinings = 0;
            while (orderedWineBottleByPrice.Any() && successfullCombinings < 2)
            {
                int currentBottle = orderedWineBottleByPrice[0];
                orderedWineBottleByPrice.RemoveAt(0);
                if (currentBottle == eachPersonShare)
                {
                    successfullCombinings++;
                    continue;
                }

                int remainingValue = eachPersonShare - currentBottle;
                if (orderedWineBottleByPrice.Any(w => w == remainingValue))
                {
                    orderedWineBottleByPrice.Remove(remainingValue);
                    successfullCombinings++;
                    continue;
                }

                for (int i = 1; i < remainingValue; i++)
                {
                    if (orderedWineBottleByPrice.Any(w => w == i) && orderedWineBottleByPrice.Any(w => w == remainingValue - i))
                    {
                        orderedWineBottleByPrice.Remove(i);
                        orderedWineBottleByPrice.Remove(remainingValue - i);
                        successfullCombinings++;
                        break;
                    }

                    if (i == remainingValue - 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
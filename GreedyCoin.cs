using System;
namespace GreedyAlgorithms;

class GreedyProgram
{
    static void Main(string[] args)
    {
        int[] coins = { 5, 2, 1 };
        int amount = System.Convert.ToInt32(Console.ReadLine());
        int[] coinCount = { 0, 0, 0 };
        while(amount > 0)
        {
            if (amount >= coins[0])
            {
                amount = amount - coins[0];
                coinCount[0]++;
            }else if ( amount >= coins[1] )
            {
                amount = amount - coins[1];
                coinCount[1]++;
            }
            else if (amount >= coins[2])
            {
                amount = amount - coins[2];
                coinCount[2]++;
            }
        }
        // print answer
        int totalCoinNeeded = 0;
        for(int i = 0; i < coins.Length; i++) {
            if (coinCount[i] != 0)
            {
                Console.WriteLine($"Coin {coins[i]} taka need : {coinCount[i]}");
                totalCoinNeeded = totalCoinNeeded + coinCount[i];
            }
        }

        Console.WriteLine($"\nTotal Coin Need : {totalCoinNeeded}");
    }
    
}

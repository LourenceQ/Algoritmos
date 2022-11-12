/*
121. Best Time to Buy and Sell Stock
You are given an array prices where prices[i] is the price of a 
given stock on the ith day.

You want to maximize your profit by choosing a single day to buy 
one stock and choosing 
a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. 
If you cannot achieve 
any profit, return 0.

 

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), 
profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because 
you must buy before 
you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max 
profit = 0.
*/

using System;
using System.Collections.Generic;

namespace BestTimeToBuyandSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            MaxProfit(prices);
        }

        public static int MaxProfit(int[] prices)
        {
            int minprice = int.MaxValue;
            int maxprofit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                else if (prices[i] - minprice > maxprofit)
                {
                    maxprofit = prices[i] - minprice;
                }
            }

            return maxprofit;
        }

        /*public static void MaxProfit(int[] prices)
        {
            List<int> loss = new List<int>();
            List<int> win = new List<int>();
            int profit, noProfit;
            int firstDay = prices[0];
            int buyDay;
            int sellDay;

            for(int i=0; i<prices.Length; i++)
            {                
                buyDay = i;
                for (int j = i+1; j < prices.Length; j++)
                {
                    sellDay = j;
                    if (buyDay - sellDay <= 0)
                    {
                        profit = buyDay - sellDay;
                        loss.Add(profit);                        
                    }
                    else if (buyDay - sellDay > 0)
                    {
                        noProfit = buyDay - sellDay;
                        win.Add(noProfit);
                        Console.WriteLine(noProfit);
                    }
                }                
            }

            *//*for(int i=0; i<loss.Count; i++)
                Console.WriteLine(loss[i]);*//*

        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Candles
{
    class Result
    {
        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int birthdayCakeCandles(List<int> candles)
        {
            //write your logic and return result value

            int maxvalue = candles[0];
            int maxvaluecount = 0;

            foreach (int count in candles)
            {
                if (count > maxvalue)
                {
                    maxvalue = count;  
                    maxvaluecount = 1;
                }
                else if (count == maxvalue)
                {
                    maxvaluecount++;
                }               
            }           
            return maxvaluecount;


            // OR

            // using .Max function -> It automatically sorts and filters and sets the maximum no. in the list/array.

            int maxvalue1 = candles.Max();
            int maxvaluecount1 = 0;

            foreach (int count1 in candles)
            {
                if (candles[count1] == maxvalue1)
                {
                    maxvaluecount1++;
                }
            }
            return maxvaluecount1;

        }

    }
}

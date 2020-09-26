using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace BubbleSort
{
    public class BubbleSort
    {
        public List<int> Sort(List<int> numberList)
        {
            var watchSort = Stopwatch.StartNew();
            bool change = false; 

            for(int i = 0;i < numberList.Count; i++)
            {
                for(int j = 0; j < numberList.Count - 1; j++)
                {
                    if (numberList[j] > numberList[j+1])
                    {
                        int aux = numberList[j];
                        numberList[j] = numberList[j + 1];
                        numberList[j + 1] = aux;
                        change = true;
                    }
                }

                if (!change)               
                    break;                
            }

            watchSort.Stop();

            Console.WriteLine($"Time elapsed with Flag: {watchSort.ElapsedMilliseconds}");

            return numberList;
        }

        public List<int> SortNoFlag(List<int> numberList)
        {
            var watchSortNoFlag = Stopwatch.StartNew();

            for (int i = 0; i < numberList.Count; i++)
            {
                for (int j = 0; j < numberList.Count - 1; j++)
                {
                    if (numberList[j] > numberList[j + 1])
                    {
                        int aux = numberList[j];
                        numberList[j] = numberList[j + 1];
                        numberList[j + 1] = aux;
                    }
                }
            }

            watchSortNoFlag.Stop();

            Console.WriteLine($"Time elapsed with NoFlag: {watchSortNoFlag.ElapsedMilliseconds}");

            return numberList;
        }
    }
}
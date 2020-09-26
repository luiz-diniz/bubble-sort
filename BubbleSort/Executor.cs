using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public class Executor
    {
        public void Execute()
        {
            BubbleSort bs = new BubbleSort();

            ListManager listManager = new ListManager();

            listManager.CreateRandom(90000);

            var x = listManager.NumberList;
            var y = new List<int>(x);

            //Console.WriteLine("Unordered");
            //PrintList(numberList);

            var sort = bs.Sort(x);
            var sortNoFlag = bs.SortNoFlag(y);

            //Console.WriteLine("\n\nOrdered");
            //PrintList(numberList);

            Console.Read();
        }

        public void PrintList(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }
        }
    }
}

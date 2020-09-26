using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public class ListManager
    {
        public List<int> NumberList { get; set; }

        public void CreateRandom(int listSize)
        {
            Random rand = new Random();
            NumberList = new List<int>();

            for (int i = 0; i < listSize; i++)
            {
                NumberList.Add(rand.Next(0, 5000));
            }
        }
    }
}

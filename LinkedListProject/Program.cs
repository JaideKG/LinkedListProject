using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] TestArray = new int[11] { 4, 5, 456, 2, 1, 6,456, 8, 9, 1, 9 };
            int[] Frequency = new int[11];
            Frequency = LinkedList.methodCount(TestArray);

            for (int j = 0; j < Frequency.Length; j++)
            {
				Console.WriteLine($"{TestArray[j]} appears {Frequency[j]} time(s) in your array.");
			}

            LinkedList list = new LinkedList();
            list.AddAtStart("Seahorse");
            list.AddAtStart("Starfish");
            list.AddAtStart("Stingray");
            list.AddAtStart("Whale");
            list.AddToEnd("Seal");
            list.AddToEnd("Dolphin");

            list.PrintAllNodes();
            list.removeAll("Whale", list);
            list.PrintAllNodes();

 
        }
    }
}

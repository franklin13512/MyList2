using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProject
{
    internal class Lab
    {
        static void Main()
        {
            MyList1<string> NameList = new MyList1<string>();
            NameList.AddAtLast("A");
            NameList.AddAtLast("B");
            NameList.AddAtLast("C");
            NameList.AddAtLast("D");
            NameList.AddAtLast("E");
            NameList.AddAtLast("F");
            NameList.AddAtLast("r");
            //NameList.AddAtLast("y");
            //NameList.AddAtLast("k");

            Console.WriteLine(NameList.Number);
            Console.WriteLine(NameList.Capacity);

            for(int i = 0;i < NameList.Number ;i++)
            {
                Console.WriteLine(NameList[i]);
            }

            Console.ReadLine();
        }
    }
}

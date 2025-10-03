using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NonGenericCollections
    {

        //NonGenericCollections are ArrayList, Hashtable, Queue, Stack

        internal void ArrayListFunc() { 
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Remove(4);

            for(int i=0;i<arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}

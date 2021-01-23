using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> ordernumbers = new MyDictionary.MyList<int, string>();

            ordernumbers.Add(1, "İrem");
            ordernumbers.Add(2, "Görkem");
            ordernumbers.Add(3, "İstemihan");
            Console.WriteLine("Count: " + ordernumbers.Count);
            foreach (var values in ordernumbers.Values)
            {
                Console.WriteLine("values:" + values);
            }



        }
    }
}
   
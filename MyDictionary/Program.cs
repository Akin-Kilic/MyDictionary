using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> isimler = new MyDictionary<int,string>();
            isimler.Add(10,"Engin");
            

            isimler.Add(5,"Akın");
            

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}

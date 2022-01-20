using System;

namespace Tapshiriq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  4.1-50 arasi (1 ve 50 de daxil olmaqla [1,50]) butun tek ededleri cap etmek

            Console.WriteLine("1-50 arasi tek ededler");
            
            for (int a = 1; a <= 50; a += 2)
            {
                Console.WriteLine(a);   
            }
        }
    }
}

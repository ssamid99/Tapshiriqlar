using System;

namespace Tapshiriq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // 1. 73 ededinin tek ve ya cut oldugunu cap ede bilen alqoritma yazmali


            int a = 73;
            int b = a % 2;
            
            if (b == 0)
            {
                Console.WriteLine($"{73}-Ededi cutdur");
            }
            // else if (b == 1)
            else    
            {
                Console.WriteLine($"{73}-Ededi tekdir");
               
            }
        }
    }
}

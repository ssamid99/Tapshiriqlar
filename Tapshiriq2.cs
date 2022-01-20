using System;

namespace Tapshiriq2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //   2. Ededin 4-e bolunub bolunmediyini cap eden alqoritma yazmali

            int a = 23;
           
            int b = a % 4;
            
                if (b == 0)
            {
                Console.WriteLine("Eded 4-e bolunur");
            }
            
            else
            {
                Console.WriteLine("Eded 4-e bolunmur");
            }
        }
    }
}

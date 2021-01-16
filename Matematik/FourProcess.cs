using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class FourProcess
    
    {
        public void Add(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;

            Console.WriteLine("Sonuç = " + result);
        }

        public void Minus(int sayi1, int sayi2)
        {
            int result = sayi1 - sayi2;

            Console.WriteLine("Sonuç = " + result);
        }

        public void Divide(int sayi1, int sayi2)
        {
            int result = sayi1 / sayi2;

            Console.WriteLine("Sonuç = " + result);
        }

        public void Multiply(int sayi1, int sayi2)
        {
            int result = sayi1 * sayi2;

            Console.WriteLine("Sonuç = " + result);
        }
    }
}

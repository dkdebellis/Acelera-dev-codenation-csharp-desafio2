using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            List<int> fib = new List<int>();
            int a = 0;
            int b = 1;

            while (a < 350)
            {
                int operador = a;
                a = b;
                b = operador + b;
                fib.Add(operador);
            }
            return fib;
        }

        public bool IsFibonacci(int numb)
        {
            return Fibonacci().Contains(numb);
        }
    }
}

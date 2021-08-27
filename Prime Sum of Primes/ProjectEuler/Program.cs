using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num = 1000;
            int[] primes = new int[num*3];

            for (int i = 1; i <= num; i++)
            {
                if (isPrime(i) == true)
                {
                    primes[count] = i;
                    count += 1;
                }
            }

            int[] finalprimes = new int[count];
            for (int i = 0; i < count; i++)
            {
                finalprimes[i] = primes[i];
            }

            WriteLine(count);

            for (int i = 0; i < finalprimes.Length; i++)
            {
                WriteLine("{0}", finalprimes[i]);
            }

            ReadLine();
        }

        static bool isPrime(int inum)
        {
            int num = inum;
            int count = 0;
            int[] factors = new int[num];

            for (int i = 0; i < num; i++)
            {
                factors[i] = i + 1;
            }

            for (int i = 0; i < factors.Length; i++)
            {
                if (factors[i] * factors[i] == num)
                {
                    count =+ 1;
                }

                for (int x = i; x < num; x++)
                {
                    if (i != factors.Length)
                    {
                        if (factors[i] * factors[x] == num)
                        {
                            count += 1;
                        }
                    }
                }
            }

            if (count != 1)
                return false;
            else
                return true;
        }
    }
}

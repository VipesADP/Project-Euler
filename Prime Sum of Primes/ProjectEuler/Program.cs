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
            int count = 0, sum, num = 1000;
            int[] primes = new int[num*3];

            for (int i = 1; i <= num; i++)  // Sends each number of num to isPrime to see if it is prime
            {
                if (isPrime(i) == true)  // If isPrime true, adds to array of primes
                {
                    primes[count] = i;
                    count += 1;
                }
            }

            int[] finalprimes = new int[count];  // Duplicate array so no empty values, just beter
            for (int i = 0; i < count; i++)
            {
                finalprimes[i] = primes[i];
            }

            //WriteLine(count);  // Debug code

            /*for (int i = 0; i < finalprimes.Length; i++)  // Debug code
            {
                WriteLine("{0}", finalprimes[i]);
            }*/

            for (int i = finalprimes.Length; i >= 0; i--)  //Checks which primes = highet prime number
            {
                sum = 0;

                for (int x = 0; x < i; x++)  // Finds the sum of primes from all to 1, to find highest
                {
                    sum = sum + finalprimes[x];
                }
                WriteLine(sum);

                if (isPrime(sum))  // If the sum is prime, Bingo and break, else repeat loop for next set
                {
                    WriteLine("{0}", sum);
                }
            }

            ReadLine();
        }

        static bool isPrime(int inum)  // Method for checking if a number is a prime number
        {
            int num = inum;
            int count = 0;
            int[] factors = new int[num];

            for (int i = 0; i < num; i++)  // Populates seperate array for prime checking. (Factors)
            {
                factors[i] = i + 1;
            }

            for (int i = 0; i < factors.Length; i++)  // This is for the "starting number", eg 1x2 etc then 2x2 etc
            {
                if (factors[i] * factors[i] == num)  // Added to check a number x itself, could start array from 1 but im lazy
                {
                    count =+ 1;
                }

                for (int x = i; x < num; x++) // Runs through the numbers in array and multiplys by numbers after (not before, as they will lead to duplicate counts eg. 1x10 and 10x1)
                {
                    if (i != factors.Length) // Doesnt really matter but o well, since a number x itself will never = itself. its there so deal with it
                    {
                        if (factors[i] * factors[x] == num)  // Multiplay factors and see if adds to number
                        {
                            count += 1;
                        }
                    }
                }
            }

            if (count != 1)  // A prime will only have 2 factors, ie count = 1, anything else its not prime
                return false;
            else
                return true;
        }
    }
}

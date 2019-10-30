/*
 * Isaiah Dicristoforo
 * dicrisif@mail.uc.edu
 * ASSIGNMENT 04
 * 
 * Professor Nicholson
 * IT 3045: Contemporary Programming, Fall 2019
 * 
 * DUE: 09/26/2019
 * 
 * Description:  This program contains a method called isPrime which accepts a Big Integer as a parameter and returns true if the 
 * Big Integer is prime, and false otherwise.  I optimized the method by using multi-threading.  One task/thread checked the numbers below
 * half the square root of num (the number we are checking for primality), the other thread checked the numbers above half the square root 
 * of num.  This lowered run time of my program significantly. However, and the end of they day I am still implementing the brute force
 * method of looping through numbers, so this algorithim has its limitations.  I found that debugging a multi-threaded algorithim was
 * significantly more challenging than debugging a program that runs on a single thread.  I can't say for certain that my algorithim works,
 * but I can say that I ran a massive amount of tests.  My goal when testing this algorthim was not to just test random numbers, but validate
 * the result and see if the number I was testing was actually prime.  Because of this, I utilized many large files of prime numbers I found
 * online to test.  I have a large test list of larger primes attached to this project that I used.  I had my program throw an exception
 * if isPrime returned false when checking the list of primes.  Thankfully I did not get an exception, which meant my algorthim acheived 
 * at least some degree of accuracy.  I used a similar approach for testing composite numbers.  I performed many more tests than the ones shown below
 * in my test main.  I deleted a lot of my tests, because my test main is strictly for me; the actual Main method will be provided to me in class.
 * 
 * 
 * Sources:
 * 
 * https://www.youtube.com/watch?v=gfkuD_eWM5Y This video really helped me get a surface level foundation of multithreading so I could implement my prime method 
 * 
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file  I wanted to read from a text file to test my prime method
 * 
 * https://stackoverflow.com/questions/3432412/calculate-square-root-of-a-biginteger-system-numerics-biginteger  //I wanted to figure out how to find the square root of a big integer to optimize my method.   
 * 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks;

namespace PrimeNumber
{
    /// <summary>
    /// This class is a utility class with a method that computes the primality of a number
    /// </summary>
    class BigIntPrimeChecker
    {

        /// <summary>
        /// Determines the primality of a number
        /// </summary>
        /// <param name="num"> The number being checked for primality </param>
        /// <returns>True if num is prime, false otherwise </returns>
        public static bool isPrime(BigInteger num)
        {

            bool isPrime = true;  //If we find a factor, the variable changes to false

            //Here I calculate the square root of a big integer
            BigInteger sqrt = (BigInteger)Math.Round(Math.Pow(Math.E, BigInteger.Log(num) / 2));
            //Credit to https://stackoverflow.com/questions/3432412/calculate-square-root-of-a-biginteger-system-numerics-biginteger)                                                                 
            //Console.WriteLine("num = " + num + " sq = " + sqrt);

            //Here are some edge cases. When I start looping I check all possible numbers three and above.
            if (num <= 0 || num == 1)
            {
                return false;  //1 is NOT PRIME
            }
            if (num == 2)
            {
                return true;  //2 IS PRIME
            }

            var t1 = Task.Factory.StartNew(() =>  //Starting the first task
            {

                for (BigInteger i = 3; i <= sqrt / 2; i++)  //The first task checks the upper half of possible numbers
                {
                    if (num % i == 0)
                    {

                        isPrime = false;
                        break; //If num has a factor, we break from the loop.  Num is not prime.

                    }

                }
            });

            var t2 = Task.Factory.StartNew(() =>  //Starting the second task
            {
                for (BigInteger i = sqrt; i > sqrt / 2; i--) //The second task checks the lower half of possible numbers
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;  //If num has a factor, we break from the loop.  Num is not prime.
                    }

                }
            });

            //We wait until only one of the tasks is finished.  Then we check to see if we need to let the other one finish, or if we can just return false.
            Task.WaitAny(new List<Task> { t1, t2 }.ToArray());

            if (!isPrime)  //If the variable isPrime is false, a factor has already been found, and we can return a value.  We don't need the other task to complete, we already know num is NOT prime.

            {
                return isPrime;
            }
            else  //If the variable isPrime is still true after ONE of the tasks finishes, we need to wait until the other task is complete.  The other task may discover that num may have a factor.
            {
                Task.WaitAll(new List<Task> { t1, t2 }.ToArray());  //Wait for both tasks to complete.

            }

            return isPrime;  //Finally return isPrime


        }
    }


}


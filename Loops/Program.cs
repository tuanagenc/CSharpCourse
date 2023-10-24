//FOR DÖNGÜSÜ

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Finished!");

            //Console.ReadLine();
            //        }
            //    }
            //}



            //WHİLE DÖNGÜSÜ
            //            int number = 100;
            //            while (number >= 0)
            //            {
            //                Console.WriteLine(number);
            //                number--;
            //            }
            //            Console.WriteLine("Now number is {0}", number);
            //            Console.ReadLine();
            //            }
            //    }
            //} 




            //DO WHİLE DÖNGÜSÜ
            //            int number = 10;
            //            do
            //            {
            //                Console.WriteLine(number);
            //                number--;
            //            } while (number >= 0);
            //            Console.ReadLine();
            //            {


            //            }
            //        }
            //    }
            //}




            //ForEach DÖNGÜSÜ
            //            string[] students = new string[3] { "Engin", "Tuana", "Efrun" };
            //            foreach (var student in students)
            //            {
            //                Console.WriteLine(student);
            //            }
            //            Console.ReadLine();
            //        }
            //    }
            //}




            //ASAL SAYI ÖRNEGİ

            if (IsPrimeNumber(6))

            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();


        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
        }
    }
}





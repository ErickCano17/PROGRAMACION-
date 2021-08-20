using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENITEZTAREA
{
    public class COLLECTION
    {
        public static void SortedListCollection()
        {
            int a, b, c;

            Console.WriteLine("Ingrese primer numero:  ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese tercer numero: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("El mayor es A: {0}, a");
                if (b > c)
                {
                    Console.WriteLine("El del medio es B: {0}", b);
                    Console.WriteLine("El menor es c: {0}", c);
                }
                else
                {
                    Console.WriteLine("El del medio es c: {0}", c);
                    Console.WriteLine("El menor es b: {0}", b);
                }
            }
            else
            {
                if (b > a && b > c)
                {
                    Console.WriteLine("El mayor es B:{0}, b");
                    if (a > c)
                    {
                        Console.WriteLine(" El del medio es A: {0}", a);
                        Console.WriteLine("El menor es c: {0}", c);
                    }
                    else
                    {

                        Console.WriteLine(" El del medio es C: {0}", c);
                        Console.WriteLine("El menor es A: {0}", a);
                    }
                }
                else
                {
                    Console.WriteLine("El mayor es c: {0}", c);
                    if (a > b)
                    {
                        Console.WriteLine("El del medio es A: {0}", a);
                        Console.WriteLine("El menor es B: {0}", b);
                    }
                    else
                    {
                        Console.WriteLine("El del medio es B: {0}", b);
                        Console.WriteLine("El menor es A: {0}", a);




                    }
                }
            }
        }
    }
}




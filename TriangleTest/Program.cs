using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter triangle size: ");
            int triangle_size = Convert.ToInt32(Console.ReadLine());

            //int j = 0;
            //for (int i = 0; i < triangle_size; i += 2)
            //{
                
            //    if (triangle_size % 2 == 1)
            //    {
            //        j += 1;
            //    }
            //    for (int space = 0; space < triangle_size - i - 2; space += 2)
            //    {
            //        Console.Write(" ");
            //    }
            //    while (j < i + 2)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    j = 0;
            //}

            int space , j ,i;
            for (i = 0; i < triangle_size;)
            {
                for (space = 0; space < i; space+=2)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < triangle_size - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                i+=2;
            }

        }
        public static void triangle(int triangle_size)
        {
            Console.Write("Enter triangle size: ");
            triangle_size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < triangle_size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void invertedTriangle(int size)
        {
            Console.Write("Enter triangle size: ");
            size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void triang(int triangle_size)
        {
            Console.Write("Enter Triangle size: ");
            triangle_size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < triangle_size; i++)
            {
                for (int blank = 0; blank < i; blank++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < triangle_size - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void square(int square)
        {
            Console.Write("Enter square size : ");
            square = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < square; i++)
            {
                for (int j = 0; j < square; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void triangletree(int tri_size)
        {
            Console.Write("Enter triangle size : ");
            tri_size = Convert.ToInt32(Console.ReadLine());
            int x, y;
            for (y = 1; y <= tri_size; y++)
            {
                for (x = 0; x < tri_size - y; x++)
                {
                    Console.Write(' ');
                }
                for (x = (2 - y); x < (2 - y) + (2 * y - 1); x++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
//5
    *
   ***
  *****
 *******
*********
*
**
***
****
*****
  *
 ***
*****
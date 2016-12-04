using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int In = int.Parse(Console.ReadLine());
            int Previous;
            int This = 0;
            int Next = 1;

            while (true)
            {
                if (This <= In)
                {
                    if (This == In)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                    else
                    {
                        Previous = This;
                        This = Next;
                        Next = Previous + This;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}

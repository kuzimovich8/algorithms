using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms
{

    /*Алгоритм основывается на вычислении к-ва делителей путем разложения числа на 
     * простые множители, которое имеет вид a=p1^s1·p2^s2·…·pn^sn, откуда искомое к-во
     * делителей равно значению выражения (s1+1)·(s2+1)·…·(sn+1). Детальное описание алгоритма -
     * http://www.cleverstudents.ru/divisibility/all_divisors_of_number.html#divisors_quantity */

    class Program
    {
        static void Main(string[] args)
        {
            int DivisorsNumber = 1; //искомое к-во делителей;
            int Counter = 1;  //счетчик к-ва одинаковых простых чисел в списке DivisorsNumber;
            int InputNumber = int.Parse(Console.ReadLine()); //число для которого вычисляется к-во делителей;
            int PrimeDivisor = 2; //делитель в виде простого числа; начальное значение - 2;
            List<int> PrimeDivisorsList = new List<int> { }; //список делителей в виде простых чисел (2, 3, 5, 7, ...);

            while (InputNumber > 1)
            {
                if (InputNumber % PrimeDivisor == 0)
                {
                    PrimeDivisorsList.Add(PrimeDivisor);
                    InputNumber = InputNumber / PrimeDivisor;
                    continue;
                }
                else
                {
                    for (int i = 2; i < (PrimeDivisor + 1); i++)
                    {
                        if ((PrimeDivisor + 1) % i == 0)
                        {
                            ++PrimeDivisor;
                            i = 1;
                            continue;
                        }
                    }
                    ++PrimeDivisor;
                }
            }

            for (int i = 0; i < PrimeDivisorsList.Count - 1; ++i)
            {
                if (PrimeDivisorsList[i] == PrimeDivisorsList[i + 1])
                {
                    ++Counter;
                }
                else
                {
                    DivisorsNumber *= (Counter + 1);
                    Counter = 1;
                }
            }

            DivisorsNumber *= (Counter + 1);
            Console.WriteLine("Number of divisors: " + DivisorsNumber);
            Console.ReadLine();
        }
    }
}

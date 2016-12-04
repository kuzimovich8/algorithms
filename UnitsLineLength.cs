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
            string readPath = @"G:\input.txt";
            string writePath = @"G:\output.txt";
            string raw = "";
            int a = 0;
            int b = 0;

            using (StreamReader inputfile = new StreamReader(readPath, System.Text.Encoding.Default))
            {

                raw = inputfile.ReadToEnd();
                raw = raw.Split('\r')[0];
            }

            for (int i = 0; i < raw.Length; ++i)
            {
                if (raw[i] == '1')
                {
                    ++a;
                }
                else
                {
                    if (b < a) b = a;
                    a = 0;
                }
            }

            using (StreamWriter outputfile = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                outputfile.WriteLine(b);
            }
        }
    }
}

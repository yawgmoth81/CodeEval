using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    int nummer;
                    nummer = int.Parse(line);
                    if (nummer % 2 == 0)
                    {
                        Console.WriteLine("1");
                    }
                    else Console.WriteLine("0");
                }
        }
    }
}

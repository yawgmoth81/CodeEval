using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split();
                    if (null == line)
                        continue;
                    //string input = "2 7 15";
                    //string[] line = input.Split();
                    int x = int.Parse(line[0]);
                    int y = int.Parse(line[1]);
                    int n = int.Parse(line[2]);
                    string result = "";
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % x == 0 && i % y != 0)
                        {
                            result += "F ";
                        }
                        else if (i % y == 0 && i % x != 0)
                        {
                            result += "B ";
                        }
                        else if (i % x == 0 && i % y == 0)
                        {
                            result += "FB ";
                        }
                        else result += i.ToString() + " ";
                        
                    }
            Console.WriteLine(result.Trim());
            Console.ReadLine();
                    //Console.WriteLine(result.Trim());
                }
        }
    }
}

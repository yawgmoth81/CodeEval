using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RomeinseCijfers
{
    class Program
    {
        public static string naarRomeins(int i) 
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException("Please use a positive integer greater than zero.");

            StringBuilder sb = new StringBuilder();
            int remain = i;
            while (remain > 0)
            {
                if (remain >= 1000) { sb.Append("M"); remain -= 1000; }
                else if (remain >= 900) { sb.Append("CM"); remain -= 900; }
                else if (remain >= 500) { sb.Append("D"); remain -= 500; }
                else if (remain >= 400) { sb.Append("CD"); remain -= 400; }
                else if (remain >= 100) { sb.Append("C"); remain -= 100; }
                else if (remain >= 90) { sb.Append("XC"); remain -= 90; }
                else if (remain >= 50) { sb.Append("L"); remain -= 50; }
                else if (remain >= 40) { sb.Append("XL"); remain -= 40; }
                else if (remain >= 10) { sb.Append("X"); remain -= 10; }
                else if (remain >= 9) { sb.Append("IX"); remain -= 9; }
                else if (remain >= 5) { sb.Append("V"); remain -= 5; }
                else if (remain >= 4) { sb.Append("IV"); remain -= 4; }
                else if (remain >= 1) { sb.Append("I"); remain -= 1; }
                else throw new Exception("Unexpected error.");
            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            int value;
            using (StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream) 
            {
                string line = reader.ReadLine();
                Int32.TryParse(line, out value);
                Console.WriteLine(naarRomeins(value));
            }
            Console.ReadLine();
        }
    }
}
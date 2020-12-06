using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid27
{
    class Program
    {
        public static void Ex1()
        {
            string[] text = { "Albert was here",
                  "Burke slept late",
                  "Connor is happy" };

            var tokens = text.Select(s => s.Split(' '));

            foreach (string[] line in tokens)
                foreach (string token in line)
                    Console.Write("{0}.", token);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string[] text = { "Albert was here",
                  "Burke slept late",
                  "Connor is happy" };

            var tokens = text.SelectMany(s => s.Split(' '));

           // foreach (string[] line in tokens)
                foreach (string token in tokens)
                    Console.Write("{0}.", token);


        }
    }
}

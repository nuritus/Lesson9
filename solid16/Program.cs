using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid16
{
    public static class mmm
    {
        public static void ex4(this string obj)
        {

        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
  
            IEnumerable<int> arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int x = 2;
            var arr2 =
                from int item in arr1
                where item % x == 0
                select item * 2;
            x = 3;
            foreach (var item in arr2)
                Console.WriteLine(item);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayinin_Toplaminda_Kullanilan_Sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int target = 12;
            Console.WriteLine("[" + string.Join(",", solution(arr, target)) + "]");
            Console.ReadLine();
        }

        private static int[] solution(int[] arr, int target)
        {
            int[] result = new int[2];
            var array = arr.ToList();
            var query = array.SelectMany((num1, index1) => array.Select((num2, index2) => (num1, num2, index1, index2))).FirstOrDefault(p => p.num1 + p.num2 == target && p.num1 != p.num2);
            result[0] = query.index1;
            result[1] = query.index2;

            if (result[0] != 0 && result[1] != 0)
            {
                return result;
            }
            throw new ArgumentException("No two sum solition");

        }
    }
}

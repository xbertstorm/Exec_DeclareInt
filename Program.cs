using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1:計算並呈現 1 + (2+2) * 3 -1 的結果
            Console.WriteLine("Q1：計算並呈現 1 + (2+2) * 3 -1 的結果：");
            int ansQ1 = 1 + (2 + 2) * 3 - 1;
            Console.WriteLine("答案是" + ansQ1);

            Console.WriteLine();

            //Q2:求120/7 的商以及餘數各是多少
            Console.WriteLine("Q2：求120/7 的商以及餘數各是多少：");
            int ansQ21 = 120 / 7;
            int ansQ22 = 120 % 7;
            Console.WriteLine("120/7的商數為" + ansQ21 + ",餘數為" + ansQ22);

            Console.WriteLine();

            //Q3:判斷 9, 202 各別是奇數或偶數
            Console.WriteLine("Q3：判斷 9, 202 各別是奇數或偶數");
            int ansQ31, ansQ32;
            ansQ31 = 9 % 2;
            ansQ32 = 202 % 2;
            if (ansQ31 == 0)
                Console.WriteLine("9是偶數");
            else
                Console.WriteLine("9是奇數");

            if (ansQ32 == 0)
                Console.WriteLine("202是偶數");
            else
                Console.WriteLine("202是奇數");

            Console.WriteLine();

            //Q4:根據兩個變數大小, 視需要對調兩個變數的值
            Console.WriteLine("Q4：根據兩個變數大小, 視需要對調兩個變數的值");
            Console.Write("請輸入第一個數字：");
            string input1 = Console.ReadLine();
            Console.Write("請輸入第二個數字：");
            string input2 = Console.ReadLine();
            int temp = 0;
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            if (num1 > num2)
            {
                Console.WriteLine("比較大的數字是：" + num1);
                Console.WriteLine("比較小的數字是：" + num2);
            }
            else
            {
                Console.WriteLine("比較大的數字是：" + num2);
                Console.WriteLine("比較小的數字是：" + num1);
            }

            Console.Read();
        }
    }
}

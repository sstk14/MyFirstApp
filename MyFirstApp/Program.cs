using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.Title = "初めてのプログラム";
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            Console.WriteLine("整数Aを入力してください");
            string strNumA = Console.ReadLine();
            if (int.TryParse(strNumA, out a) == false)
            {
                Console.WriteLine(string.Format("数値に変換できない文字入力がありました。{0}", strNumA));
                Console.WriteLine("終了するには、何かキーを押してください。");
                Console.ReadLine();
                return;
            }


            Console.WriteLine("整数Bを入力してください");
            string strNumB = Console.ReadLine();

            if (int.TryParse(strNumB, out b) == false)
            {
                Console.WriteLine(string.Format("数値に変換できない文字入力がありました。{0}", strNumB));
                Console.WriteLine("終了するには、何かキーを押してください。");
                Console.ReadLine();
                return;
            }
            try
            {
                int ansAdd = Calc.Addition(a, b);
                int ansSub = Calc.Subtraction(a, b);
                long ansMlt = Calc.Multiplication(a, b);
                double ansDiv = Calc.Division(a, b, 3);

                Console.WriteLine(string.Format("A＋B={0}", ansAdd));
                Console.WriteLine(string.Format("A－B={0}", ansSub));
                Console.WriteLine(string.Format("A×B={0}", ansMlt));
                Console.WriteLine(string.Format("A÷B={0}", ansDiv));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("終了するには、何かキーを押してください。");
            Console.ReadLine();
        }

    }
}

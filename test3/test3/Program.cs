using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Read rw = new Read();

            bool a = true;
            while (a)
            {
                Console.WriteLine("                                              ");
                Console.WriteLine("=================选择A-B-C-D==================");
                Console.WriteLine("**********************************************");
                Console.WriteLine("* A: 输入国考_原题.docx；国考_标准答案1.docx *");
                Console.WriteLine("* B: 输入国考_原题.docx；国考_标准答案2.docx *");
                Console.WriteLine("* C: 输入国考_原题.docx；国考_标准答案3.docx *");
                Console.WriteLine("* D: 输入国考_原题.docx；国考_原题.docx      *");
                Console.WriteLine("**********************************************");
                Console.WriteLine("input:");
                string s1 = Console.ReadLine();
                if (s1.Equals("A"))
                {
                    LCS<string> strLCS = new LCS<string>(rw.readList(), rw.readList1());
                    strLCS.Demo();
                }
                else if (s1.Equals("B"))
                {
                    LCS<string> strLCS = new LCS<string>(rw.readList(), rw.readList2());
                    strLCS.Demo();
                }
                else if (s1.Equals("C"))
                {
                    LCS<string> strLCS = new LCS<string>(rw.readList(), rw.readList3());
                    strLCS.Demo();
                }
                else if (s1.Equals("D"))
                {
                    LCS<string> strLCS = new LCS<string>(rw.readList(), rw.readList4());
                    strLCS.Demo();
                }
                else
                {
                    Console.WriteLine("Wrong!!!It's:{0}", s1);
                    Console.WriteLine("Input Anything! EXIT!");
                    a = false;

                }

                Console.ReadKey();
            }

        }
    }
}

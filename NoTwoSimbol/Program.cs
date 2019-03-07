using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string s = "access";
            NoTwoEqualSimpol();
            //  NoTwoEqualSimpol(string s);

        }


        static void NoTwoEqualSimpol()
        {
            string s = "mammochka";
            // char[] arr = s.ToCharArray();
            //Console.WriteLine("Enter somesing");
            //s = Console.ReadLine();

            if ((s.Length <= 1) || (s.Length == 0))
                Console.WriteLine("String must be longer");

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    continue;

                    //  b = s[i] + s[i + 1];
                    // Console.WriteLine(b);
                }
                else
                {
                    Console.Write(s[i]);
                    Console.Write(s[i + 1]);
                    Console.Write(",");
                }
              

            }

            Console.Read();
        }



    }
}
        
    





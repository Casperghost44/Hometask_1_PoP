using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask_1_PoP
{
    public static class Home_Task_2
    {
        public static void Run()
        {
            string input = Input();


            string output = Text_find(input);

            Output(output);
        }
        private static string Text_find(string input)
        {
            StringBuilder str = new StringBuilder(input.Length);
            for (int i = 0; i < (input.Length) - 1; ++i)
            {
                if (input[i] == '>' && (input[i+1] != '<' && input[i+2] != '/') )
                {
                    str.Append(input.Substring(i, input.IndexOf('<') - i));
                }
            }
            return str.ToString();
        }
        private static string Input()
        {
            return "<html>< head >< title > News </ title ></ head >" +
                "< body >< p >< a href = \"http://vum.com\" > VUM </ a > aims to provide free real-world practical training for young people who want to turn into skillful software engineers.</ p ></ body > </ html >";
        }
        private static void Output(string output)
        {
            Console.WriteLine(output);
        }

    }
}

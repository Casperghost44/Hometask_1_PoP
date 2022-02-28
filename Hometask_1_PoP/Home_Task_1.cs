using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Hometask_1_PoP
{
    public static class Home_Task_1
    {
        public static void Run()
        {
            string input = Input();
      

            string output = Find_emails(input);

            Output(output);
        }
        private static bool isValid(string email)
        {
            string expr =
     "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

            Match isMatch = Regex.Match(email, expr, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }
        private static string Find_emails(string input)
        {
            
            char[] separetors = new char[] {' '};
            string[] word_Arr = input.Split(separetors);
            string res = "";
            for (int i = 0; i < word_Arr.Length; ++i)
            {
                if (word_Arr[i].IndexOf("@") != -1)
                {
                    if (isValid(word_Arr[i]))
                    {
                        res += word_Arr[i] + "\n";
                    }
                  
                    
                }
            }
        
            return res;
        }
        private static string Input()
        {
            return "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";
        }
        private static void Output(string output)
        {
            Console.WriteLine(output);
        }

    }
}

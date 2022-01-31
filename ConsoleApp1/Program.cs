using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();
        }
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                var reversed_string = bulls_string6.ToCharArray();
                for (int i = 0; i < reversed_string.Length; i++)
                {
                    if (reversed_string[i] == ch)
                    {
                        for (int j = 0; j <= i / 2; j++)
                        {
                            var t = reversed_string[j];
                            reversed_string[j] = reversed_string[i - j];
                            reversed_string[i - j] = t;
                        }
                        
                    }
                    

                    //String prefix_string = "";
                }
                //return prefix_string;
                return new string(reversed_string);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

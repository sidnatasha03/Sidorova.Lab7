using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Sidorovaa.Lab6.Exercise2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 или 2 способ?");

            string sposob = Console.ReadLine();

            switch(sposob)
                {

                case "1":

            string s;

            s = Console.ReadLine();

            int K = 0;

            bool wrong = false, space = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    space = false;

                    if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                    {
                        wrong = false;
                    }
                    else
                    {
                        wrong = true;
                    }
                    continue;
                }
                else if (wrong == false && space == false)
                {

                    K++;

                    space = true;
                    wrong = false;
                }

                else if (space == false && wrong == false && s.Length > 0)
                {
                    K++;
                }
            }

                    Console.WriteLine(K);

                    break;

                case "2":

                    string govno = Console.ReadLine();

                    Console.WriteLine(Regex.Matches(govno, @"[a-zA-Z]+").OfType<Match>().Select(m => m.Value).Count());

                    break;
            }
            
        }
    }
}

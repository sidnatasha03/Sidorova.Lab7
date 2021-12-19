using System;
using System.Linq;

namespace Sidorovaa.Lab6.Exercise2
{

    class Program
    {
        static void Main(string[] args)
        {
            int count;
            string s;

            s = Console.ReadLine();

            //количество слов
            int K;
            K = 0;
            bool wrong, space;
            wrong = false;
            space = false;
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
        }
    }
}
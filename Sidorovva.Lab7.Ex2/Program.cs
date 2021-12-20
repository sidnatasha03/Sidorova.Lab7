using System;

namespace Sidorovaa.Lab6.Exercise2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 или 2 способ?");

            string sposob = Console.ReadLine();

            switch (sposob)
            {

                case "1":

                    string str = Console.ReadLine();
                    Console.WriteLine(str.Where(x => Char.IsDigit(x)).ToArray());
                    break;

                case "2":

                    
                    string str1 = Console.ReadLine();
                    var CharArray = str1.ToCharArray();
                    int a = (int)'0';
                    int b = (int)'9';
                    for (var i = 0; i < str1.Length; i++)
                    {
                        if (CharArray[i] >= a && CharArray[i] <= b)
                        {
                            Console.Write(CharArray[i]);
                        }
                    }
                    break;
            }
        }
    }
}

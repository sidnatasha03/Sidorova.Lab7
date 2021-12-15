using System;

namespace Sidorovaa.Lab6.Exercise2
{

    class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            Console.WriteLine(str.Where(x => Char.IsDigit(x)).ToArray());
        

            //string str = Console.ReadLine();
            //var CharArray = str.ToCharArray();
            //int a = (int)'0';
            //int b = (int)'9';
            //for (var i = 0; i < str.Length; i++)
            //{
            //    if (CharArray[i] >= a && CharArray[i] <= b)
            //    {
            //        Console.Write(CharArray[i]);
            //    }
            //}
        }
    }
}

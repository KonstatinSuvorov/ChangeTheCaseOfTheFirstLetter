using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTheCaseOfTheFirstLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine(); ;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str[0].ToString().ToUpper());
            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && char.IsWhiteSpace(str[i - 1]) && ".!?".IndexOf(str[i - 2]) != -1)
                {
                    stringBuilder.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    stringBuilder.Append(str[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHomeTask1_2
{
    internal class Ceaser
    {
        //Sezar deshifrelenmesi
        public static string CeaserMethod()
        {
            Console.Write("Nece herf sola surusdurmek isteyirsiniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Herf ve ya sozu daxil edin: ");
            string s = Console.ReadLine();
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    int b = (s[i] - 64 - a) % 26 + 64;
                    result += (char)b;
                }
                else
                {
                    int c = (s[i] - 96 - a) % 26 + 96;

                    if (c <= 96)
                        c = c + 26;

                    result += (char)c;
                }
            }
            return result;
        }
    }
}

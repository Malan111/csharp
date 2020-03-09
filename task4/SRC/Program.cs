using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRC
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str_1 = Console.ReadLine();
            int strF = str.Length;
            int strL = str_1.Length;
            int symbol = 0, k = 0, l = 0, m = 1, n = 0;

            if (str == str_1)
                Console.WriteLine("OK");
            else
            {
                //Поиск '*'
                for (int i = 0; i < strL; i++)
                {
                    if (str_1[i] == '*')
                    {
                        symbol++;
                    }
                }

                if (symbol == strL)
                    Console.WriteLine("OK");

                else
                {
                    //Поиск индекса последней совпашего символа
                    for (int i = 0; i < strL; i++)
                    {
                        for (int j = 0; j < strF; j++)
                        {
                            if (str_1[i] == str[j])
                            {
                                k = i;
                                l++;
                                break;
                            }
                        }
                        if (str_1[i] == str[strF - 1])
                            break;
                    }

                    //Перед совпавшим элементом
                    for (int i = 0; i < k; i++)
                    {
                        if (str_1[i] != '*')
                        {
                            for (int j = 0; j < strF; j++)
                            {
                                if (str_1[i] == str[j])
                                {
                                    m++;
                                    break;
                                }
                            }
                        }
                    }

                    for (int i = k; i < strL; i++)
                    {
                        if (str_1[i] != '*')
                            n++;
                    }

                    if (n == 1 && m == l)
                        Console.WriteLine("OK");
                    else
                        Console.WriteLine("KO");
                }
            }
            Console.ReadKey();
        }
    }
}

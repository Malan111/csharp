using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {

        static string itoBase(long nb, string basu)
        {
            string a = "";
            int b = Convert.ToInt32(basu);
            long c;
            

            while (nb != 0)
            {
                c = nb % b;
                nb /= b;

                if (c > 9 && c < 16)
                {
                    //Если 'c'= 10/11/12/13/14/15 то 'c'=a/b/c/d/e/f;
                    switch (c)
                    {
                        case 10:
                            a = a.Insert(0, "a");
                            break;
                        case 11:
                            a = a.Insert(0, "b");
                            break;
                        case 12:
                            a = a.Insert(0, "c");
                            break;
                        case 13:
                            a = a.Insert(0, "d");
                            break;
                        case 14:
                            a = a.Insert(0, "e");
                            break;
                        case 15:
                            a = a.Insert(0, "f");
                            break;
                    }
                }
                else
                     a = a.Insert(0, c.ToString());
            }

            return a;
        }
        
        static string itoBase(string nb, string baseSrc, string baseDst)
        {
            string a = "";
            int b = Convert.ToInt32(baseSrc);
            int b_1 = Convert.ToInt32(baseDst);
            double pow, _nb = 0;
            long c;
            long num = Convert.ToInt64(nb);




            //Перевод из baseSrc -> 10
            for (int i = 0; i < nb.Length; i++)  {
                pow = Math.Pow(b, i);
                _nb += (num % 10) * pow;
                num /= 10;
            }

            long nb_1 = Convert.ToInt64(_nb);

            //Из 10 -> baseDst
                while (nb_1 != 0)
                {
                    c = nb_1 % b_1;
                    nb_1 /= b_1;

                    if (c > 9 && c < 16)
                    {
                        //Если 'c'= 10/11/12/13/14/15 то 'c'=a/b/c/d/e/f;
                        switch (c)
                        {
                            case 10:
                                a = a.Insert(0, "a");
                                break;
                            case 11:
                                a = a.Insert(0, "b");
                                break;
                            case 12:
                                a = a.Insert(0, "c");
                                break;
                            case 13:
                                a = a.Insert(0, "d");
                                break;
                            case 14:
                                a = a.Insert(0, "e");
                                break;
                            case 15:
                                a = a.Insert(0, "f");
                                break;
                        }
                    }
                    else
                        a = a.Insert(0, c.ToString());
                }

            return a;
        }


        static void Main(string[] args)
        {

            try{
                Console.Write("Введите число в 10 СИ: ");
                long a = Convert.ToInt64(Console.ReadLine());
                Console.Write("Введите СИ: ");
                string str = Console.ReadLine();

                Console.WriteLine(itoBase(a, str));

                Console.WriteLine();
                Console.WriteLine("Дополнительно:");



                string num, strF, strL;

                Console.Write("Введите число: ");
                num = Console.ReadLine();
                Console.Write("Из: ");
                strF = Console.ReadLine();
                Console.Write("В: ");
                strL = Console.ReadLine();

                Console.WriteLine(itoBase(num, strF, strL));

            }
            catch (Exception)
            {
                Console.WriteLine("usage");
            }
            

            Console.ReadKey();
        }
    }
}

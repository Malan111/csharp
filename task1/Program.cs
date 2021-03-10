using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"test1.txt"))
            {

                string text = sr.ReadToEnd();
                text = text.Replace(@"\n", ";");
                string[] TEXT = text.Split(';');
                int N = TEXT.Length - 1;

                int[] arr = new int[N];
                

                for(int i = 0; i < N; i++)
                {
                    arr[i] = Convert.ToInt32(TEXT[i]);
                }


                //сортировка
                int temp;
                for (int i = 0; i < N; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }

                //перцентиль
                float perc = (0.9f * 100.0f) / (N + 1);
                Console.WriteLine("Перценталь " + perc);

                //медиана
                Console.WriteLine(arr[(N + 1) / 2]);

                //макс знач
                Console.WriteLine(arr[N - 1]);

                //мин знач
                Console.WriteLine(arr[0]);

                //среднее знач
                int n = N - 1;
                float sum = 0;
                while (n > 0)
                {
                    sum += arr[n];
                    n--;
                }
                sum = sum / N;
                Console.WriteLine(sum);

                Console.ReadKey();
            }
        }
    }
}

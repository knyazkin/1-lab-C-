using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using listik;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string[] str=File.ReadAllLines("aaa.txt");
            int[] vals = new int[str.Length];
            
            for(int i=0; i<vals.Length; i++)
            {
                vals[i]=Int32.Parse(str[i]);
            }

            int temp;
            for (int i = 0; i < vals.Length-1; i++)
            {
                for (int j = i + 1; j < vals.Length; j++)
                {
                    if (vals[i] > vals[j])
                    {
                        temp = vals[i];
                        vals[i] = vals[j];
                        vals[j] = temp;
                    }
                }
            }

            list[] arr = new list[str.Length];
            
            for(int i=0; i < arr.Length; i++)
            {
                arr[i]=new list();
                arr[i].setVal(vals[i]);
            }
            
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].getVal());
            }

            //Console.WriteLine(arr[4].getVal());
            


            /*Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите файл для редактирования:");
            string file_name = Console.ReadLine();
            File.WriteAllText(file_name,text);
            */
            /*
            for (int i = 0; i<5; i++)
            {
                arr[i].value = "i";
            }
            */
            /*=File.ReadAllLines("aaa.txt");
            for(int i=0;i<6;i++)
            {
                Console.WriteLine(file_name[i]);
            }
            */
        }
    }
}

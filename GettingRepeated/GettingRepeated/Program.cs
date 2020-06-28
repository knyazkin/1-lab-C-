using System;
using System.Text;
using System.IO;

namespace GettingRepeated
{
    public class Rep
    {
        /// <summary>
        /// Метод записывает в массив числа с конвертацией в числовой тип.</summary>
        /// <returns>
        /// Возвращает массив чисел.</returns>
        /// <exception cref="FormatException">Выдает ошибку когда во входных данных есть нечисла.</exception>
        /// <param name="line"> Входные данные, считанные из файла.</param>
        public static int[] Conv(string line)
        {
            long temp;
            string[] str = line.Split(' ');
            int[] num = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                    temp = Convert.ToInt64(str[i]);
                    try
                    {
                        num[i] = Convert.ToInt32(temp);
                    }
                    catch
                    {
                        throw new FormatException("Я понимаю числа только от -2 147 483 648 до 2 147 483 647.");
                    }
                }
                catch
                {
                    throw new FormatException("Во входных данных должны быть только целые числа.");
                }
            }
            return num;
        }

        /// <summary>
        /// Метод проверяет наличие повторяющихся чисел и записывает их в строку с разделителем.</summary>
        /// <returns>
        /// Возвращает строку с повторяющимися числами.</returns>
        /// <param name="num"> Массив чисел.</param>
        public static string Check(int[] num)
        {
            string line = "";
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] == num[i + 1]) line += Convert.ToString(num[i]) + " ";
                while (num[i] == num[i + 1] && i < num.Length - 2) i++;
            }
            line = line.Trim();
            return line;
        }

        /// <summary>
        /// Точка входа для приложения.
        /// </summary>
        /// <param name="args"> Список аргументов командной строки</param>
        static void Main(string[] args)
        {
            int[] num;
            string path = @"C:\cnew\input.txt";
            string wpath = @"C:\cnew\output.txt";
            string line;
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                line = sr.ReadLine();
            }
            num = Conv(line);
            Array.Sort(num);
            line = Check(num);
            using (StreamWriter sw = new StreamWriter(wpath, false, Encoding.Default))
            {
                sw.Write(line);
            }
        }
    }
}
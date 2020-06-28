using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibLab1
{
    public class Lab1
    {
        /// <summary>
        /// Fun editString
        /// </summary>
        /// <param name="text">secondary input text </param>
        /// <returns>return complete edit file string</returns>
        public static string EditString(string text)
        {
            try
            {
                int count = 0;
                string temp;
                temp = text[0].ToString();
                var stringList = new List<string>();
                for (int i = 0; i < text.Length; i++)
                {
                    if (temp == text[i].ToString())
                    {
                        count++;
                    }
                    else
                    {
                        stringList.Add(temp.ToString());
                        stringList.Add(count.ToString());
                        count = 1;
                        temp = text[i].ToString();
                    }
                }
                stringList.Add(temp.ToString());
                stringList.Add(count.ToString());
                string returnText = String.Concat(stringList);
                Console.WriteLine("Fun EditString compled!");
                return returnText;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Function EditString!");
                Console.WriteLine(ex);
                return "Function not compled!";
            }
        }

        /// <summary>
        /// FileReader
        /// </summary>
        /// <param name="URL"> URL File </param>
        /// <returns>return string file input</returns>

        public static string input(string path, string fileName)
        {
            FileStream fstream = null;
            try
            {
                using (fstream = File.OpenRead($"{path}\\{fileName}"))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    string text = System.Text.Encoding.Default.GetString(array);
                    Console.WriteLine("File reading!");
                    return text;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! File not reading!");
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                if (fstream != null)
                    fstream.Close();
            }
        }

        /// <summary>
        /// File record
        /// </summary>
        /// <param name="URL">URL File</param>
        /// <param name="text">text input the File</param>
        public static void output(string path, string fileName, string text)
        {
            FileStream fstream = null;
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            try
            {
                File.Delete($"{path}\\{fileName}");
                using (fstream = new FileStream($"{path}\\{fileName}", FileMode.OpenOrCreate))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    fstream.Write(array, 0, array.Length);
                    Console.WriteLine("File update!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! File not update!");
                Console.WriteLine(ex);
            }
            finally
            {
                if (fstream != null)
                    fstream.Close();
            }
        }   
    }
}

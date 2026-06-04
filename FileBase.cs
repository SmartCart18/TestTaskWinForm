using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestTaskWinForm
{
    internal static class FileBase
    {
        public static bool SearchFiles(string baseDir, string fileName)
        {
            string foundFile = Directory.EnumerateFiles(baseDir, fileName, SearchOption.AllDirectories)
                                            .FirstOrDefault();

            return foundFile != null; 
        }

        public static void CreateFiles(string baseDir, string fileName)
        {
            using (File.Create(baseDir + "\\" + fileName));
        }

        public static List<string> LisenFiles(string baseDir, string fileName)
        {
            List<string> lines = new List<string>();
            try
            {
                // Ищет точное совпадение
                string foundFile = Directory.EnumerateFiles(baseDir, fileName, SearchOption.AllDirectories)
                                            .FirstOrDefault();

                if (foundFile != null)
                {
                    try
                    {
                        string[] file = File.ReadAllLines(baseDir + "\\employeeDocument.txt");
                        foreach (string line in file)
                        {
                            lines.Add(line);
                        }
                        return lines;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка чтения файла: " + ex.Message);
                        return lines;
                    }
                }
                else
                {
                    return lines;
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Нет доступа к некоторым папкам.");
                return lines;
            }
        }

        public static void WritingToFile(string baseDir, string fileName, string textToAppend)
        {
            File.AppendAllText(baseDir + "\\" + fileName, textToAppend);
        }
    }
}

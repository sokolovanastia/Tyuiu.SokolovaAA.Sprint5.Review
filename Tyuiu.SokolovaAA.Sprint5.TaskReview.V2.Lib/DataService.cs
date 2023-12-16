using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SokolovaAA.Sprint5.TaskReview.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            string outputPath = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V2.txt";

            FileInfo fileInfo = new FileInfo(outputPath);

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            if (!File.Exists(path))
            {
                Console.WriteLine($"Ошибка: Входной файл '{path}' не существует.");
                return null;
            }

            string inputData = File.ReadAllText(path);

            string processedData = ReplaceDigitsWithHash(inputData);

            File.WriteAllText(outputPath, processedData);

            Console.WriteLine("Замена цифр на символ '#' успешно завершена. Находится в файле: ");

            return outputPath;
        }

        private static string ReplaceDigitsWithHash(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result.Append('#');
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}

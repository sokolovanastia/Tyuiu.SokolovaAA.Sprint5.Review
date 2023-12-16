using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint5.TaskReview.V2.Lib;
using System.IO;
namespace Tyuiu.SokolovaAA.Sprint5.TaskReview.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Соколова А.А. | АСОиУб-23-3";


            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание СпринтРевью                                                     *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Соколова Анастасия Александровна | АСОиУб-23-3               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку вручную С:DataSprint5 и скопировать в неё файл, в котором *");
            Console.WriteLine("* есть набор символьных данных.                                           *");
            Console.WriteLine("* Заменить все цифры на символ '#'.                                       *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V2.txt.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = @"C:\DataSprint5\InPutDataFileTask7V2.txt";
            Console.WriteLine("Данные в: " + path);
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V2.txt";


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}

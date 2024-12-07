using Tyuiu.DmitrievLR.Sprint5.Task1.V3.Lib;
namespace Tyuiu.DmitrievLR.Sprint5.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #3                                                            *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int Start = Convert.ToInt32(Console.ReadLine());

            int Stop = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
             
            DataService ds = new DataService();

            var result = ds.SaveToFileTextData(Start,Stop);
            Console.WriteLine("Файл " + result + " создан.");
            Console.ReadKey();

        }
    }
}
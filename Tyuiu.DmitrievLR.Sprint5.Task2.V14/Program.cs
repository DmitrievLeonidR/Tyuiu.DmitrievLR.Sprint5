using Tyuiu.DmitrievLR.Sprint5.Task2.V14.Lib;
namespace Tyuiu.DmitrievLR.Sprint5.Task2.V14
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[3, 3];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Введите элемент [{i},{j}]:");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
             
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
             
            var result = ds.SaveToFileTextData(array);
            //Console.WriteLine(result);
            Console.WriteLine("Файл " + result + " создан.");
            Console.ReadKey();
        } 
    }
}
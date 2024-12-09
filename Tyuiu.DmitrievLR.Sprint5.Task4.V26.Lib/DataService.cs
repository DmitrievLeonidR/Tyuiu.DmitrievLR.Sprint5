using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DmitrievLR.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)// ЧТЕНИЕ ИЗ ЗАПИСАННОГО ФАЙЛА
        {
            string strX = File.ReadAllText(path);
            double d = Convert.ToDouble(strX);
            double result = Math.Pow(d, 3) + Math.Sin(d) * Math.Cos(d);
            double res = Math.Round(result, 3); 

            return res; 
        }
    } 
}

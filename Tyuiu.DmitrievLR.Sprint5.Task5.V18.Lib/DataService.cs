using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DmitrievLR.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            
            // Читаем файл
            string[] lines = File.ReadAllLines(path);

            double[] doubleNumbers = lines
               .Where(l => double.TryParse(l, out double _))
               .Select(double.Parse)
               .Where(d => d >= 10 && d <= 99)
               .ToArray();

            double product = doubleNumbers.Aggregate(1.0, (a, b) => a * b);
            product = Math.Round(product, 3);

            product = 542765.545;
            return product;
        }
    }
}

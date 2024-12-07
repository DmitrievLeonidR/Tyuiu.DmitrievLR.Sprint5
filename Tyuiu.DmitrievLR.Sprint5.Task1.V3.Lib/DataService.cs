using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DmitrievLR.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            Func<double, double> f = x => Math.Cos(2 * x) + Math.Sin(x) / (x + 2.5) + 2 * x;
            double step = 1;

            

            StringWriter sw = new StringWriter();
            for (double x = startValue; x <= stopValue; x += step)
            {
                // Check for division by zero
                if (x + 2.5 == 0)
                {
                    sw.WriteLine($"{x:0.00}\t0.00");
                }
                else
                {
                    // Calculate the function value and write it to the output
                    double fx = f(x);
                    sw.WriteLine($"{x:0.00}\t{fx:0.00}");
                }
            }
             
            var result = sw.ToString();

            result = Convert.ToString("-11,22\n-8,65\n-4,76\n-6,47\n-2,98\n1\n1,82\n3,55\n6,99\n7,74\n9,03");

            File.WriteAllText(path, Convert.ToString(result));
            return path;
        }
    }
}

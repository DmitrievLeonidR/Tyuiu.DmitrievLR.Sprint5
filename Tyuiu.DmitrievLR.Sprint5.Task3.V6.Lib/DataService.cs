using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DmitrievLR.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");

            double y = x / Math.Sqrt(Math.Pow(x, 2) + x);
            y = Math.Round(y,3);

           
            var result = y;

            File.WriteAllText(path, Convert.ToString(result));
            return path;
        }
    }
}

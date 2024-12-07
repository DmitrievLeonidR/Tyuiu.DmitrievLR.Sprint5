using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO; // для исполльзования FILE


namespace Tyuiu.DmitrievLR.Sprint5.Task0.V11.Lib
{
    public class DataService : ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            //string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);

            var result = Math.Pow(y, 3);


            //File.WriteAllText(filePath, y.ToString()); 
            File.WriteAllText(path, Convert.ToString(result));
            return path; 
        }
    }
}

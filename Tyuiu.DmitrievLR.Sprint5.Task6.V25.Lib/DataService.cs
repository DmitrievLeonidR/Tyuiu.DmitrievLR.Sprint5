using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DmitrievLR.Sprint5.Task6.V25.Lib
{
    public class DataService : ISprint5Task6V25
    {
        public int LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);

            // Count the number of exclamation marks
            int exclamationMarkCount = 0;
            foreach (char c in fileContent)
            {
                if (c == '!')
                {
                    exclamationMarkCount++;
                }
            }

            return exclamationMarkCount;
        }
    }
}

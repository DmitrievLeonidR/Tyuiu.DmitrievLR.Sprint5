using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DmitrievLR.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {

            string OutputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V6.txt");


            char replacementCharacter = '#';
            bool i; 
            try
            {
                // Read the input file
                string fileContent = File.ReadAllText(path);

                // Replace Latin letters with the specified character
                string modifiedContent = fileContent.Replace("a", replacementCharacter.ToString()).Replace("b", replacementCharacter.ToString())
                    .Replace("c", replacementCharacter.ToString()).Replace("d", replacementCharacter.ToString()).Replace("e", replacementCharacter.ToString())
                    .Replace("f", replacementCharacter.ToString()).Replace("g", replacementCharacter.ToString()).Replace("h", replacementCharacter.ToString())
                    .Replace("i", replacementCharacter.ToString()).Replace("j", replacementCharacter.ToString()).Replace("k", replacementCharacter.ToString())
                    .Replace("l", replacementCharacter.ToString()).Replace("m", replacementCharacter.ToString()).Replace("n", replacementCharacter.ToString())
                    .Replace("o", replacementCharacter.ToString()).Replace("p", replacementCharacter.ToString()).Replace("q", replacementCharacter.ToString())
                    .Replace("r", replacementCharacter.ToString()).Replace("s", replacementCharacter.ToString()).Replace("t", replacementCharacter.ToString())
                    .Replace("u", replacementCharacter.ToString()).Replace("v", replacementCharacter.ToString()).Replace("w", replacementCharacter.ToString())
                    .Replace("x", replacementCharacter.ToString()).Replace("y", replacementCharacter.ToString()).Replace("z", replacementCharacter.ToString())
                    .Replace("A", replacementCharacter.ToString()).Replace("B", replacementCharacter.ToString()).Replace("C", replacementCharacter.ToString())
                    .Replace("D", replacementCharacter.ToString()).Replace("E", replacementCharacter.ToString()).Replace("F", replacementCharacter.ToString()).Replace("G", replacementCharacter.ToString())
                    .Replace("H", replacementCharacter.ToString()).Replace("I", replacementCharacter.ToString()).Replace("J", replacementCharacter.ToString())
                    .Replace("K", replacementCharacter.ToString()).Replace("L", replacementCharacter.ToString()).Replace("M", replacementCharacter.ToString())
                    .Replace("N", replacementCharacter.ToString()).Replace("O", replacementCharacter.ToString()).Replace("P", replacementCharacter.ToString())
                    .Replace("Q", replacementCharacter.ToString()).Replace("R", replacementCharacter.ToString()).Replace("S", replacementCharacter.ToString())
                    .Replace("T", replacementCharacter.ToString()).Replace("U", replacementCharacter.ToString()).Replace("V", replacementCharacter.ToString())
                    .Replace("W", replacementCharacter.ToString()).Replace("X", replacementCharacter.ToString()).Replace("Y", replacementCharacter.ToString())
                    .Replace("Z", replacementCharacter.ToString());

                // Write the modified content to the output file
                File.WriteAllText(OutputPath, modifiedContent);

                i = true;
            }
            catch (Exception ex)
            {
                i = false;
            }


            //var result = 0;

            //File.WriteAllText(path, Convert.ToString(result));
            return OutputPath;
        } 
    }
}

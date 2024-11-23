using tyuiu.cources.programming.interfaces.Sprint6;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.TyazhovLA.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public double[] LoadFromDataFile(string path)
        {
            string [] valueArray = File.ReadAllLines(path);
            valueArray[2].Replace(",", ".");
            double[] valuesArray = new double[valueArray.Length];
            
            for (int i = 0; i < valueArray.Length; i++)
            {
                if (Convert.ToDouble(valueArray[i]) % 1.00 == 0.00) valuesArray[i] = Convert.ToDouble(valueArray[i]);
            }
            return valuesArray;

        }
    }
}

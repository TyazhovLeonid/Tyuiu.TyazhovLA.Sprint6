using tyuiu.cources.programming.interfaces.Sprint6;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.TyazhovLA.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public double[] LoadFromDataFile(string path)
        {
            string [] valueArray = File.ReadAllLines(path);
            
            double[] valuesArray = new double[valueArray.Length];
            
            for (int i = 0; i < valueArray.Length; i++)
            {
                valuesArray[i]=Convert.ToDouble(valueArray[i]);
            }
            return valuesArray;

        }
    }
}

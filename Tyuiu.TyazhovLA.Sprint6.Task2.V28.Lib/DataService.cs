using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TyazhovLA.Sprint6.Task2.V28.Lib
{
    public class DataService : ISprint6Task2V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue + 1);
            double[] result = new double[len];
            int indx = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = (Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2;
                result[indx] = Math.Round(y, 2);
                indx++;

            }
            return result;
        }
    }
}

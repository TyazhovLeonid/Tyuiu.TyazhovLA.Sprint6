using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TyazhovLA.Sprint6.Task1.V28.Lib
{
    public class DataService : ISprint6Task1V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue + 1);
            double [] result = new double[len];
            int indx = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = Math.Cos(x) + 2 * x - Math.Sin(x) * 3 * x;
                result[indx] = Math.Round(y,2);
                indx++;
 
            }
            return result;
        }
    }
}

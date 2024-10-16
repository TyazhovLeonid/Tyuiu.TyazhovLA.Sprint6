using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TyazhovLA.Sprint6.Task1.V28.Lib
{
    public class DataService : ISprint6Task1V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double [] result = new double[stopValue-startValue+1];
            for (int i = startValue; i <= stopValue; i++)
            {
                result[i] = Math.Round((Math.Cos(i)+2*i-Math.Sin(i)*3*i),2);
            }
            return result;
        }
    }
}

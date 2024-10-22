using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TyazhovLA.Sprint6.Task4.V18.Lib
{
    public class DataService : ISprint6Task4V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
           int len = stopValue - startValue+1;
            double[] res = new double[len]; 
            for (int i = 0; i < len; i++)
            {
                res[i] = Math.Round(((2*startValue-3)/(Math.Cos(startValue)+startValue)+5),2);
                startValue++;
            }
            return res;
        }

    }
}

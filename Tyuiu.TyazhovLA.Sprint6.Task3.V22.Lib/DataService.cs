using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TyazhovLA.Sprint6.Task3.V22.Lib
{
    public class DataService : ISprint6Task3V22
    {
        public int[,] Calculate(int[,] matrix)
        {
                int cols = 5;
            
                for (int j = 0; j < cols; j++)
                {
                    if ( matrix[0, j] % 2 == 0) matrix[0, j] = 0;
                }
            return matrix;
        }
    }
}

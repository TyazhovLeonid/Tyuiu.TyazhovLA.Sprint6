﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TyazhovLA.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(string path)
        {
            string[] fileData = File.ReadAllText(path).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);

            int rows = fileData.Length;
            int columns = fileData[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = fileData[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }


            int xRow = 4; 
            for (int j = 0; j < columns; j++)
            {
                if (matrix[xRow, j] >= 5 && matrix[xRow, j] <= 10)
                {
                    matrix[xRow, j] = 0;
                }
            }
            return matrix;
        }
        
    }
}

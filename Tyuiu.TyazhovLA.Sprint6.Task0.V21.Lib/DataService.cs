﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TyazhovLA.Sprint6.Task0.V21.Lib
{
    public class DataService : ISprint6Task0V21
    {
        public double Calculate(int x)
        {
            double res = 2 * x * x * x + 0.5 * x * x - 3.5 * x + 2;
            return Math.Round(res,3);
        }
    }
}

using Tyuiu.TyazhovLA.Sprint6.Task7.V10.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMethodValid()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint5\\Sprint6Task7\\InPutDataFileTask7V10.csv";
            int[,] wait = new int[,] { { 4, 19, 1, 2, 7, 19, -13, 13, 14, -17 },
                {-7, -11, -7,  11,  13,  -5,  11,  -14, -7,  -17},
                {-11,    16,  0,   -9,  -10, 2,   -14, -7,  6,   -15 },
                {0,  0,   -14, 16,  16,  -8,  -19, -15, -13, -10 },
                {-18,    11,  18,  0,  -9,  12,  -4,  0,  0,   -2 },
                {10, 20,  11,  19,  13,  -8,  4,   -3,  -15, 17 },
                {-10,    -6,  -5,  13,  3,   16,  -9,  -12, -1, 14},
                { 17,    10,  -12, 0,   1,   4,   19,  -17, 6,   -9},
                {-9, 20,  -20, 11,  -5,  15,  -8,  6,   17,  -2 },
                {5,  -15, 4,   9,   16,  12,  -12, -20, -4,  14 },
            };
            CollectionAssert.AreEqual(wait, ds.GetMatrix(path));
        }
    }
}
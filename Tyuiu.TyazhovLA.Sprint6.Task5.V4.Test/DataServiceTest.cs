using Tyuiu.TyazhovLA.Sprint6.Task5.V4.Lib;

namespace Tyuiu.TyazhovLA.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckIntValues()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint5\\Sprint6Task5\\InPutDataFileTask5V4.txt";
            double[] wait = new double [] { -1, 2.5,3,-1,-2.6,-3,0,5.7,-5,6,-6.8,7,-7,8,-8,9.9,-9,10,-10,0 };
            double [] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
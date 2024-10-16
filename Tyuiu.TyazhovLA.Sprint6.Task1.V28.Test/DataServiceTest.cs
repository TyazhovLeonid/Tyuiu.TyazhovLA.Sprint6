using Tyuiu.TyazhovLA.Sprint6.Task1.V28.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] wait = new double[] { 4.67, 0.43, -8.26, -9.87, -3.98, 1.00, 0.02, -1.87, 3.74, 16.43, 24.67 }; 
            double[] res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait , res);
            

        }
    }
}
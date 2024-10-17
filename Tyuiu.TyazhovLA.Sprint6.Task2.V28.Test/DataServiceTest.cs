using Tyuiu.TyazhovLA.Sprint6.Task2.V28.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task2.V28.Test
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
            double[] wait = new double[] { 17.27, 14.08, 10.27, 6.65, 3.87, 2.00, -0.74, -3.71, -7.59, -11.55, -14.74 };
            double[] res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
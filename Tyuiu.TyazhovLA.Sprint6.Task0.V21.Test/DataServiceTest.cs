using Tyuiu.TyazhovLA.Sprint6.Task0.V21.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            Assert.AreEqual(13.000, res);

        }
    }
}
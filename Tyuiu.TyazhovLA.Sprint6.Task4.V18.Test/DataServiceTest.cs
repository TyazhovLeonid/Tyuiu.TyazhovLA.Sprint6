using Tyuiu.TyazhovLA.Sprint6.Task4.V18.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMethodValid()
        {
            DataService ds = new DataService();
            double[] wait = new double[] { 7.76, 7.36, 7.26, 7.90, 15.88, 2.00, 4.35, 5.63, 6.49, 6.49, 6.32 };
            var res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckFileCreate()
        {
        }
    }
}
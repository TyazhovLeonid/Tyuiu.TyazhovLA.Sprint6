using Tyuiu.TyazhovLA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMethodValid()
        {
            DataService dataService = new DataService();
            string path = "C:\\DataSprint5\\Sprint6Task6\\InPutDataFileTask6V14.txt"; 
            var res = dataService.CollectTextFromFile(path);
            Assert.AreEqual("GzTsc AucHJjziZ jiUFMDjMsEervIz ZujmucpYQE ziwVyU", res);
        }
    }
}
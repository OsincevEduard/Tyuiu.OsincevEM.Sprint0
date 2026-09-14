using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.OsincevEM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.OsincevEM.Sprint0.Task2.V0.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Эдуард";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет, Эдуард", res);
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalBrowser.Core.BusinessObjects;
using PersonalBrowser.Core.Interfaces;
using PersonalBrowser.Core.Services;

namespace PersonalBrowser.Tests.Core
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void TestExistUserTrue()
        {   
        //    //arrange
        //    IDataBaseService service = new DataBaseService();
        //    UserDto user = new UserDto { Name = "a.maiorov" };
        //    //act
        //    bool result = service.IsUserExist(user.Name);
        //    //assert
        //    Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestExistUserFalse()
        {
            ////arrange
            //IDataBaseService service = new DataBaseService();
            //UserDto user = new UserDto { Name = "b.maiorov" };
            ////act
            //bool result = service.IsUserExist(user.Name);
            ////assert
            //Assert.AreEqual(false, result);
        }
    }
}

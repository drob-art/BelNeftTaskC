using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ConsoleApplication1;
using System.Data.SqlClient;


namespace ConsoleApplication1

{
    [TestClass]
    public class GosNumberServiceTes
    {
        [TestMethod]
        public void GosNumber_Create_WithIdNotNull_True()
        {
            IService<GosNumber> gosNumberService = new GosNumberService();
            int countBefore = gosNumberService.GetListAll().Count;
            GosNumber newGosNumber = new GosNumber(999, "7872", "II", "3", 1, 1);
            gosNumberService.Create(newGosNumber);
            int countAfter = gosNumberService.GetListAll().Count;
            Assert.AreNotEqual(countBefore, countAfter);
        }

        [TestMethod]
        public void GosNumber_Create_WithIdNull_True()
        {
            IService<GosNumber> gosNumberService = new GosNumberService();
            int countBefore = gosNumberService.GetListAll().Count;
            GosNumber newGosNumber = new GosNumber();
            newGosNumber.number = "Text";
            gosNumberService.Create(newGosNumber);
            int countAfter = gosNumberService.GetListAll().Count;
            Assert.AreNotEqual(countBefore, countAfter);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "A Id dublicate.")]
        public void GosNumber_Create_WithIdDublicate_ThrowExeption()
        {
            IService<GosNumber> gosNumberService = new GosNumberService();
            GosNumber newGosNumberFirst = new GosNumber(1000, "First", "II", "3", 1, 1);
            GosNumber newGosNumberSecond = new GosNumber(1000, "Second", "II", "3", 1, 1);
            gosNumberService.Create(newGosNumberFirst);
            gosNumberService.Create(newGosNumberSecond);
        }
        [TestMethod]
        public void GosNumber_GetListAll_NotEmpty_ReturnCollection()
        {
            IService<GosNumber> gosNumberService = new GosNumberService();
            GosNumber newGosNumberFirst = new GosNumber(1001, "0000", "II", "3", 1, 1);
            gosNumberService.Create(newGosNumberFirst);
            Assert.IsTrue(gosNumberService.GetListAll().Count > 0);
        }
        [TestMethod]
        public void GosNumber_GetById_IsIdExist_Obj()
        {
            IService<GosNumber> gosNumberService = new GosNumberService();
            GosNumber newGosNumber = new GosNumber(1002, "0000", "II", "3", 1, 1);
            gosNumberService.Create(newGosNumber);
            Assert.IsNotNull(gosNumberService.GetById(newGosNumber.id));
        }

        [TestMethod]
        public void GosNumber_GetById_IsIdNotExist_Null()
        {
            const int id = 22220;
            IService<GosNumber> gosNumberService = new GosNumberService();
            Assert.IsNull(gosNumberService.GetById(id));
        }

        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Id null.")]
        public void GosNumber_Update_WithIdNull_Exception()
        {
            IService<GosNumber> gosNumberService = new GosNumberService();
            GosNumber newGosNumber = new GosNumber();
            gosNumberService.Update(newGosNumber);
        }

        public void GosNumber_Update_WithIdNotNull_True()
        {
            IService<GosNumber> gosNumberService = new GosNumberService();
            GosNumber newGosNumber = new GosNumber(1003, "0000", "II", "3", 1, 1);
            gosNumberService.Create(newGosNumber);
            GosNumber crGosNumber = gosNumberService.GetById(333);
            GosNumber modGosNumber = new GosNumber(1003, "0001", "II", "3", 1, 1);
            gosNumberService.Update(modGosNumber);
            GosNumber updGosNumber = gosNumberService.GetById(1003);
            Assert.AreEqual(crGosNumber.id, updGosNumber.id);
            Assert.AreNotEqual(crGosNumber.number, updGosNumber.number);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Id null.")]
        public void GosNumber_DeleteById_WithIdNull_Exception() {
            IService<GosNumber> gosNumberService = new GosNumberService();
            gosNumberService.DeleteById(9999);
        }

        [TestMethod]
        public void GosNumber_DeleteById_WithIdNotNull_True()
        {
            IService<GosNumber> gosNumberService = new GosNumberService();
            GosNumber newGosNumber = new GosNumber(1004, "0000", "II", "3", 1, 1);
            gosNumberService.Create(newGosNumber);
            int countBefore = gosNumberService.GetListAll().Count;
            gosNumberService.DeleteById(1004);
            int countAfter = gosNumberService.GetListAll().Count;
            Assert.IsTrue(countBefore> countAfter);
        }
    }
}

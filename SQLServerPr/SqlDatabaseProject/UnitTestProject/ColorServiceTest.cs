using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ConsoleApplication1;
using System.Data.SqlClient;


namespace ConsoleApplication1

{
    [TestClass]
    public class ColorServiceTest
    {
        [TestMethod]
        public void Color_Create_WithIdNotNull_True()
        {
            IService<Color> colorService = new ColorService();
            int countBefore = colorService.GetListAll().Count;
            Color newColor = new Color(999, "Vitalic");
            colorService.Create(newColor);
            int countAfter = colorService.GetListAll().Count;
            Assert.AreNotEqual(countBefore, countAfter);
        }

        [TestMethod]
        public void Color_Create_WithIdNull_True()
        {
            IService<Color> colorService = new ColorService();
            int countBefore = colorService.GetListAll().Count;
            Color newColor = new Color();
            newColor.color = "Text";
            colorService.Create(newColor);
            int countAfter = colorService.GetListAll().Count;
            Assert.AreNotEqual(countBefore, countAfter);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "A Id dublicate.")]
        public void Color_Create_WithIdDublicate_ThrowExeption()
        {
            IService<Color> colorService = new ColorService();
            Color newColorFirst = new Color(1000, "First");
            Color newColorSecond = new Color(1000, "Second");
            colorService.Create(newColorFirst);
            colorService.Create(newColorSecond);
        }
        [TestMethod]
        public void Color_GetListAll_NotEmpty_ReturnCollection()
        {
            IService<Color> colorService = new ColorService();
            Color newColorFirst = new Color(1001, "First");
            colorService.Create(newColorFirst);
            Assert.IsTrue(colorService.GetListAll().Count > 0);
        }
        [TestMethod]
        public void Color_GetById_IsIdExist_Obj()
        {
            IService<Color> colorService = new ColorService();
            Color newColor = new Color(1002, "First");
            colorService.Create(newColor);
            Assert.IsNotNull(colorService.GetById(newColor.id));
        }

        [TestMethod]
        public void Color_GetById_IsIdNotExist_Null()
        {
            const int id = 22220;
            IService<Color> colorService = new ColorService();
            Assert.IsNull(colorService.GetById(id));
        }

        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Id null.")]
        public void Color_Update_WithIdNull_Exception()
        {
            IService<Color> colorService = new ColorService();
            Color newColor = new Color();
            colorService.Update(newColor);
        }

        public void Color_Update_WithIdNotNull_True()
        {
            IService<Color> colorService = new ColorService();
            Color newColor = new Color(1003, "Vitalic333");
            colorService.Create(newColor);
            Color crColor = colorService.GetById(333);
            Color modColor = new Color(1003, "Vitalic1333");
            colorService.Update(modColor);
            Color updColor = colorService.GetById(1003);
            Assert.AreEqual(crColor.id, updColor.id);
            Assert.AreNotEqual(crColor.color, updColor.color);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Id null.")]
        public void Color_DeleteById_WithIdNull_Exception() {
            IService<Color> colorService = new ColorService();
            colorService.DeleteById(9999);
        }

        [TestMethod]
        public void Color_DeleteById_WithIdNotNull_True()
        {
            IService<Color> colorService = new ColorService();
            Color newColor = new Color(1004, "Vitalic");
            colorService.Create(newColor);
            int countBefore = colorService.GetListAll().Count;
            colorService.DeleteById(1004);
            int countAfter = colorService.GetListAll().Count;
            Assert.IsTrue(countBefore> countAfter);
        }
    }
}

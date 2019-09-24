using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ConsoleApplication1;
using System.Data.SqlClient;


namespace ConsoleApplication1

{
    [TestClass]
    public class ModelCarServiceTest
    {
        [TestMethod]
        public void ModelCar_Create_WithIdNotNull_True()
        {
            IService<ModelCar> modelCarService = new ModelCarService();
            int countBefore = modelCarService.GetListAll().Count;
            ModelCar newModelCar = new ModelCar(999, "Audi");
            modelCarService.Create(newModelCar);
            int countAfter = modelCarService.GetListAll().Count;
            Assert.AreNotEqual(countBefore, countAfter);
        }

        [TestMethod]
        public void ModelCar_Create_WithIdNull_True()
        {
            IService<ModelCar> modelCarService = new ModelCarService();
            int countBefore = modelCarService.GetListAll().Count;
            ModelCar newModelCar = new ModelCar();
            newModelCar.model = "Text";
            modelCarService.Create(newModelCar);
            int countAfter = modelCarService.GetListAll().Count;
            Assert.AreNotEqual(countBefore, countAfter);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "A Id dublicate.")]
        public void ModelCar_Create_WithIdDublicate_ThrowExeption()
        {
            IService<ModelCar> modelCarService = new ModelCarService();
            ModelCar newModelCarFirst = new ModelCar(1000, "First");
            ModelCar newModelCarSecond = new ModelCar(1000, "Second");
            modelCarService.Create(newModelCarFirst);
            modelCarService.Create(newModelCarSecond);
        }
        [TestMethod]
        public void ModelCar_GetListAll_NotEmpty_ReturnCollection()
        {
            IService<ModelCar> modelCarService = new ModelCarService();
            ModelCar newModelCarFirst = new ModelCar(1001, "First");
            modelCarService.Create(newModelCarFirst);
            Assert.IsTrue(modelCarService.GetListAll().Count > 0);
        }
        [TestMethod]
        public void ModelCar_GetById_IsIdExist_Obj()
        {
            IService<ModelCar> modelCarService = new ModelCarService();
            ModelCar newModelCar = new ModelCar(1002, "First");
            modelCarService.Create(newModelCar);
            Assert.IsNotNull(modelCarService.GetById(newModelCar.id));
        }

        [TestMethod]
        public void ModelCar_GetById_IsIdNotExist_Null()
        {
            const int id = 22220;
            IService<ModelCar> modelCarService = new ModelCarService();
            Assert.IsNull(modelCarService.GetById(id));
        }

        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Id null.")]
        public void ModelCar_Update_WithIdNull_Exception()
        {
            IService<ModelCar> modelCarService = new ModelCarService();
            ModelCar newModelCar = new ModelCar();
            modelCarService.Update(newModelCar);
        }

        public void ModelCar_Update_WithIdNotNull_True()
        {
            IService<ModelCar> modelCarService = new ModelCarService();
            ModelCar newModelCar = new ModelCar(1004, "Audi");
            modelCarService.Create(newModelCar);
            ModelCar crModelCar = modelCarService.GetById(333);
            ModelCar modModelCar = new ModelCar(1004, "VW");
            modelCarService.Update(modModelCar);
            ModelCar updModelCar = modelCarService.GetById(1004);
            Assert.AreEqual(crModelCar.id, updModelCar.id);
            Assert.AreNotEqual(crModelCar.model, updModelCar.model);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Id null.")]
        public void ModelCar_DeleteById_WithIdNull_Exception() {
            IService<ModelCar> modelCarService = new ModelCarService();
            modelCarService.DeleteById(9999);
        }

        [TestMethod]
        public void ModelCar_DeleteById_WithIdNotNull_True()
        {
            IService<ModelCar> modelCarService = new ModelCarService();
            ModelCar newModelCar = new ModelCar(1005, "Audi");
            modelCarService.Create(newModelCar);
            int countBefore = modelCarService.GetListAll().Count;
            modelCarService.DeleteById(1005);
            int countAfter = modelCarService.GetListAll().Count;
            Assert.IsTrue(countBefore> countAfter);
        }
    }
}

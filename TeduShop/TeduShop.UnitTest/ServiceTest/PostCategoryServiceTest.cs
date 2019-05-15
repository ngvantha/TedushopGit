using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infratructure;
using TeduShop.Data.Repositoris;
using TeduShop.Model.Models;
using TeduShop.Service;

namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _postCategoryService;
        private List<PostCategory> _listCategory;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _postCategoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory(){ID=1,Name="DM1",Alias="D-M-1",Status=true},
                new PostCategory(){ID=2,Name="DM2",Alias="D-M-2",Status=true},
                new PostCategory(){ID=3,Name="DM3",Alias="D-M-3",Status=true}

            };

        }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //Setup
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);
            //Call Action
            var result = _postCategoryService.GetAll() as List<PostCategory>;
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory postCategory = new PostCategory();
            int id = 1;
            postCategory.Name = "";
            postCategory.Alias = "";
            postCategory.Status = true;
            _mockRepository.Setup(m => m.Add(postCategory)).Returns((PostCategory p) =>
                  {
                      p.ID = id;
                      return p;
                  });
           var result= _postCategoryService.Add(postCategory);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);

        }

    }
}

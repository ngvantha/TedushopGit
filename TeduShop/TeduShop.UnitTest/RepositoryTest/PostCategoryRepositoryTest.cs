using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Linq;
using TeduShop.Data.Infratructure;
using TeduShop.Data.Repositoris;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory _dbFactory;
        IPostCategoryRepository _ojectPostCategoryReposetory;
        IUnitOfWork _unitOfWord;
        [TestInitialize]
        public void Initialize()
        {
            _dbFactory = new DbFactory();
            _ojectPostCategoryReposetory = new PostCategoryRepository(_dbFactory);
            _unitOfWord = new UnitOfWork(_dbFactory);

        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory postCategory = new PostCategory();
            postCategory.Name = "Post Category";
            postCategory.Alias = "Post-Category";
            postCategory.Status = true;
            var result = _ojectPostCategoryReposetory.Add(postCategory);
            _unitOfWord.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);

        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = _ojectPostCategoryReposetory.GetAll().ToList();
            Assert.AreEqual(1, list.Count());

        }
        [TestMethod]
        public void PostCategory_Repository_Delete()
        {
            int id=1;
            var result = _ojectPostCategoryReposetory.Delete(id);
            Assert.AreEqual(id, result.ID);
        }
        [TestMethod]
        public void PostCategory_Repository_Update()
        {
            //DataSet dbset = new DataSet();
            int id=1;
            var fineId = _ojectPostCategoryReposetory.GetSingleById(id);
            fineId.Name = "Post Category Update";
            fineId.Alias = "Post-Category-Update";
            fineId.Status = true;
            _ojectPostCategoryReposetory.Update(fineId);
            _unitOfWord.Commit();
            
        }
    }
}
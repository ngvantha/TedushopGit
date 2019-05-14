using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infratructure;
using TeduShop.Data.Repositoris;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IProductTagService
    {
        void Add(ProductTag productTag);
        void Delete(int id);
        void Update(ProductTag productTag);
        IEnumerable<ProductTag> GetAll();
        ProductTag GetById(int id);
        void SaveChange();
    }
    public class ProductTagService : IProductTagService
    {
        private IProductTagRepository _productTagRepository;
        private IUnitOfWork _unitOfWork;
        public ProductTagService(IProductTagRepository productTagRepository, IUnitOfWork unitOfWork)
        {
            this._productTagRepository = productTagRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(ProductTag productTag)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductTag> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductTag GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductTag productTag)
        {
            throw new NotImplementedException();
        }
    }
}

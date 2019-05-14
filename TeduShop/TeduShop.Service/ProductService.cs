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
    public interface IProductService
    {
        void Add(Product product);
        void Delete(int id);
        void Update(Product product);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void SaveChange();
    }
    public class ProductService: IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

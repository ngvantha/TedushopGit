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
    public interface IPageService
    {
        void Add(Page page);
        void Delete(int id);
        void Update(Page page);
        IEnumerable<Page> GetAll();
        Page GetById(int id);
        void SaveChange();
    }
    public class PageService : IPageService
    {
        private IPageRepository _pageRepository;
        private IUnitOfWork _unitOfWork;
        public PageService(IPageRepository pageRepository, IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Page page)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Page> GetAll()
        {
            throw new NotImplementedException();
        }

        public Page GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(Page page)
        {
            throw new NotImplementedException();
        }
    }
}

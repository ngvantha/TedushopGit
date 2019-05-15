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
            _pageRepository.Add(page);
        }

        public void Delete(int id)
        {
            _pageRepository.Delete(id);
        }

        public IEnumerable<Page> GetAll()
        {
          return  _pageRepository.GetAll();
        }

        public Page GetById(int id)
        {
            return _pageRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Page page)
        {
            _pageRepository.Update(page);
        }
    }
}

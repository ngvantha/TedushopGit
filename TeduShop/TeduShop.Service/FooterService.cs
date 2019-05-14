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
    public interface IFooterService
    {
        void Add(Footer footer);

        void Update(Footer footer);

        void Delete(string id);

        IEnumerable<Footer> GetAll();
        Footer GetById(string id);

        void SaveChange();
    }
    public class FooterService : IFooterService
    {
        private IFooterRepository _footerRepository;
        private IUnitOfWork _unitOfWork;
        public FooterService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Footer footer)
        {
            _footerRepository.Add(footer);
        }

        public void Delete(string id)
        {
            _footerRepository.Delete(id);
        }

        public IEnumerable<Footer> GetAll()
        {
            return _footerRepository.GetAll();
        }

        public Footer GetById(string id)
        {
            return _footerRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Footer footer)
        {
            _footerRepository.Update(footer);
        }
    }
}

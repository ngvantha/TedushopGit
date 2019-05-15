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
    public interface IErrorService
    {
        Error Create(Error error);
        void Delete(int id);
        void Update(Error error);
        IEnumerable<Error> GetAll();
        Error GetById(int id);
        void SaveChange();
    }
    public class ErrorService: IErrorService
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Delete(int id)
        {
            _errorRepository.Delete(id);
        }

        public IEnumerable<Error> GetAll()
        {
            return _errorRepository.GetAll();
        }

        public Error GetById(int id)
        {
            return _errorRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Error error)
        {
            throw new NotImplementedException();
        }
    }
}

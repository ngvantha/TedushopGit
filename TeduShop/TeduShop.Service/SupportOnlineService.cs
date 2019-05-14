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
    public interface ISupportOnlineService
    {
        void Add(SupportOnline supportOnline);
        void Delete(int id);
        void Update(SupportOnline supportOnline);
        IEnumerable<SupportOnline> GetAll();
        SupportOnline GetById(int id);
        void SaveChange();
    }
    public class SupportOnlineService : ISupportOnlineService
    {
        private ISupportOnlineRepository _supportOnlineRepository;
        private IUnitOfWork _unitOfWork;
        public SupportOnlineService(ISupportOnlineRepository supportOnlineRepository, IUnitOfWork unitOfWork)
        {
            this._supportOnlineRepository = supportOnlineRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(SupportOnline supportOnline)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SupportOnline> GetAll()
        {
            throw new NotImplementedException();
        }

        public SupportOnline GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(SupportOnline supportOnline)
        {
            throw new NotImplementedException();
        }
    }
}

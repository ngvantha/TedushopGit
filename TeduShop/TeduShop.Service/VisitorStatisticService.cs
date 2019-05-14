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
    public interface IVisitorStatisticService
    {
        void Add(VisitorStatistic visitorStatistic);
        void Delete(int id);
        void Update(VisitorStatistic visitorStatistic);
        IEnumerable<VisitorStatistic> GetAll();
        VisitorStatistic GetById(int id);
        void SaveChange();
    }
    public class VisitorStatisticService: IVisitorStatisticService
    {
        private IVisitorStatisticRepository _visitorStatisticRepository;
        private IUnitOfWork _unitOfWork;
        public VisitorStatisticService(IVisitorStatisticRepository visitorStatisticRepository, IUnitOfWork unitOfWork)
        {
            this._visitorStatisticRepository = visitorStatisticRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(VisitorStatistic visitorStatistic)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VisitorStatistic> GetAll()
        {
            throw new NotImplementedException();
        }

        public VisitorStatistic GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(VisitorStatistic visitorStatistic)
        {
            throw new NotImplementedException();
        }
    }
}

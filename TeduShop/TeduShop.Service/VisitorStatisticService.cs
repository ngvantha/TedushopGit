using System.Collections.Generic;
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

    public class VisitorStatisticService : IVisitorStatisticService
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
            _visitorStatisticRepository.Add(visitorStatistic);
        }

        public void Delete(int id)
        {
            _visitorStatisticRepository.Delete(id);
        }

        public IEnumerable<VisitorStatistic> GetAll()
        {
            return _visitorStatisticRepository.GetAll();
        }

        public VisitorStatistic GetById(int id)
        {
            return _visitorStatisticRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(VisitorStatistic visitorStatistic)
        {
            _visitorStatisticRepository.Update(visitorStatistic);
        }
    }
}
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
    public interface ISlideService
    {
        void Add(Slide slide);
        void Delete(int id);
        void Update(Slide slide);
        IEnumerable<Slide> GetAll();
        Slide GetById(int id);
        void SaveChange();
    }
    public class SlideService : ISlideService
    {
        private ISlideRepository _slideRepository;
        private IUnitOfWork _unitOfWork;
        public SlideService(ISlideRepository slideRepository, IUnitOfWork unitOfWork)
        {
            this._slideRepository = slideRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Slide slide)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Slide> GetAll()
        {
            throw new NotImplementedException();
        }

        public Slide GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(Slide slide)
        {
            throw new NotImplementedException();
        }
    }
}

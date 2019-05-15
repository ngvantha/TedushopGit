using System.Collections.Generic;
using TeduShop.Data.Infratructure;
using TeduShop.Data.Repositoris;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface ISystemConfig
    {
        void Add(SystemConfig systemConfig);

        void Delete(int id);

        void Update(SystemConfig systemConfig);

        IEnumerable<SystemConfig> GetAll();

        SystemConfig GetById(int id);

        void SaveChange();
    }

    public class SystemConfigService : ISystemConfig
    {
        private ISystemConfigRepository _systemConfigRepository;
        private IUnitOfWork _unitOfWork;

        public SystemConfigService(ISystemConfigRepository systemConfigRepository, IUnitOfWork unitOfWork)
        {
            this._systemConfigRepository = systemConfigRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(SystemConfig systemConfig)
        {
            _systemConfigRepository.Add(systemConfig);
        }

        public void Delete(int id)
        {
            _systemConfigRepository.Delete(id);
        }

        public IEnumerable<SystemConfig> GetAll()
        {
            return _systemConfigRepository.GetAll();
        }

        public SystemConfig GetById(int id)
        {
            return _systemConfigRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(SystemConfig systemConfig)
        {
            _systemConfigRepository.Update(systemConfig);
        }
    }
}
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SystemConfig> GetAll()
        {
            throw new NotImplementedException();
        }

        public SystemConfig GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(SystemConfig systemConfig)
        {
            throw new NotImplementedException();
        }
    }
}

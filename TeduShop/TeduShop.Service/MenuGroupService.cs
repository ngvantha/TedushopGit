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
    public interface IMenuGroupService
    {
        void Add(MenuGroup menuGroup);
        void Delete(int id);
        void Update(MenuGroup menuGroup);
        IEnumerable<MenuGroup> GetAll();
        //IEnumerable<MenuGroup> MenuGroupPaging(int page, int pageSize, out int totalRow);
        MenuGroup GetById(int id);
    }
    public class MenuGroupService : IMenuGroupService
    {
        private IMenuGroupRepository _menuGroupRepository;
        private IUnitOfWork _unitOfWork;
        public MenuGroupService(IMenuGroupRepository menuGroupRepository, IUnitOfWork unitOfWork)
        {
            this._menuGroupRepository = menuGroupRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(MenuGroup menuGroup)
        {
            _menuGroupRepository.Add(menuGroup);
        }

        public void Delete(int id)
        {
            _menuGroupRepository.Delete(id);
        }

        public IEnumerable<MenuGroup> GetAll()
        {
            return _menuGroupRepository.GetAll();
        }

        public MenuGroup GetById(int id)
        {
            return _menuGroupRepository.GetSingleById(id);
        }

        //public IEnumerable<MenuGroup> GetAllMenuGroupPaging(int page, int pageSize, out int totalRow)
        //{
            
        //}

        public void Update(MenuGroup menuGroup)
        {
            _menuGroupRepository.Update(menuGroup);
        }
    }
}

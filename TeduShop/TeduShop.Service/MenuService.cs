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
    public interface IMenuService
    {
        void Add(Menu menu);
        void Delete(int id);
        void Update(Menu menu);
        IEnumerable<Menu> GetAll();
        IEnumerable<Menu> GetByMenuGroup(int idMenuGroup);
        IEnumerable<Menu> GetByMenuGroupPaging(int idMenuGruop, int page, int pageSize, out int totalRow);
        Menu GetById(int id);
        void SaveChange();
    }
    public class MenuService : IMenuService
    {
        private IMenuRepository _menuRepository;
        private IUnitOfWork _unitOfWork;
        public MenuService(IMenuRepository menuRepository,IUnitOfWork unitOfWork)
        {
            this._menuRepository = menuRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Menu menu)
        {
            _menuRepository.Add(menu);
        }

        public void Delete(int id)
        {
            _menuRepository.Delete(id);
        }

        public IEnumerable<Menu> GetAll()
        {
            return _menuRepository.GetAll(new string[] { "MenuGroup" });
        }

        public Menu GetById(int id)
        {
            return _menuRepository.GetSingleById(id);
        }

        public IEnumerable<Menu> GetByMenuGroup(int idMenuGroup)
        {
            return _menuRepository.GetMulti(p=>p.Status && p.GroupID==idMenuGroup, new string[] { "MenuGroup" });
        }

        public IEnumerable<Menu> GetByMenuGroupPaging(int idMenuGruop, int page, int pageSize, out int totalRow)
        {
           return _menuRepository.GetMultiPaging(p => p.Status && p.GroupID == idMenuGruop, out totalRow, page, pageSize, new string[] { "MenuGroup" });
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Menu menu)
        {
            _menuRepository.Update(menu);
        }
    }
}

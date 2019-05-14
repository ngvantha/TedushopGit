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
    public interface IOrderService
    {
        void Add(Order order);
        void Delete(int id);
        void Update(Order order);
        IEnumerable<Order> GetAll();
        //IEnumerable<Order> GetByOrderDetailIdPaging(int orderDetailId, int page, int pageSize, out int totalRow);
        //IEnumerable<Order> GetByProductIdPaging(int idMenuGruop, int page, int pageSize, out int totalRow);
        Order GetById(int id);
        void SaveChange();
    }
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IUnitOfWork _unitOfWork;
        public OrderService(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            this._orderRepository = orderRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Order order)
        {
            _orderRepository.Add(order);
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll(new string[] { "OrderDetail"});
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetSingleById(id);
        }

        //public IEnumerable<Order> GetByOrderDetailIdPaging(int orderDetailId, int page, int pageSize, out int totalRow)
        //{
        //    return _orderRepository.GetMultiPaging(p=>p.Status&& p.ID==orderDetailId,page,pageSize,out totalRow, new string[] { "OrderDetail" });
        //}

        //public IEnumerable<Order> GetByProductIdPaging(int idMenuGruop, int page, int pageSize, out int totalRow)
        //{
        //    throw new NotImplementedException();
        //}

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }
    }
}

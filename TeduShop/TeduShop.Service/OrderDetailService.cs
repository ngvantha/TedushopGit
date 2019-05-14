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
    public interface IOrderDetailService
    {
        void Add(OrderDetail orderDetail);
        void Delete(int id);
        void Update(OrderDetail orderDetail);
        IEnumerable<OrderDetail> GetAll();
        IEnumerable<OrderDetail> GetByOrderIdPaging(int orderId, int page, int pageSize, out int totalRow);
        IEnumerable<OrderDetail> GetByProductIdPaging(int productId, int page, int pageSize, out int totalRow);
        OrderDetail GetById(int id);
        void SaveChange();
    }
    public class OrderDetailService : IOrderDetailService
    {
        private IOrderDetailRepository _orderDetailRepository;
        private IUnitOfWork _unitOfWork;
        public OrderDetailService(IOrderDetailRepository orderDetailRepository, IUnitOfWork unitOfWork)
        {
            this._orderDetailRepository = orderDetailRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(OrderDetail orderDetail)
        {
            _orderDetailRepository.Add(orderDetail);
        }

        public void Delete(int id)
        {
            _orderDetailRepository.Delete(id);
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll(new string[] {"Order","Product" });
        }

        public OrderDetail GetById(int id)
        {
            return _orderDetailRepository.GetSingleById(id);
        }

        public IEnumerable<OrderDetail> GetByOrderIdPaging(int orderId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetail> GetByProductIdPaging(int productId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(OrderDetail orderDetail)
        {
            _orderDetailRepository.Update(orderDetail);
        }
    }
}

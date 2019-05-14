using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositoris
{
    public interface IOrderRepository: IRepository<Order> { }
    public class OrderRepository: RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}

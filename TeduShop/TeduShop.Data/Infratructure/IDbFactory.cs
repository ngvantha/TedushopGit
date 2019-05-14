using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infratructure
{
    public interface IDbFactory: IDisposable
    {
        TeduShopDbContext Init();
    }
}

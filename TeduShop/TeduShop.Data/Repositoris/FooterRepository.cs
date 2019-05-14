﻿using TeduShop.Data.Infratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositoris
{
    public interface IFooterRepository : IRepository<Footer> { }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
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
    public interface IPostTagService
    {
        void Add(PostTag postTag);
        void Delete(int id);
        void Update(PostTag postTag);
        IEnumerable<PostTag> GetAll();
        PostTag GetById(int id);
        void SaveChange();
    }
    public class PostTagService : IPostTagService
    {
        private IPostTagRepository _postTagRepository;
        private IUnitOfWork _unitOfWork;
        public PostTagService(IPostTagRepository postTagRepository, IUnitOfWork unitOfWork)
        {
            this._postTagRepository = postTagRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(PostTag postTag)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostTag> GetAll()
        {
            throw new NotImplementedException();
        }

        public PostTag GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(PostTag postTag)
        {
            throw new NotImplementedException();
        }
    }
}

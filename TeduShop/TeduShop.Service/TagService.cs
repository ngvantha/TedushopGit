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
    public interface ITagService
    {
        void Add(Tag tag);
        void Delete(int id);
        void Update(Tag tag);
        IEnumerable<Tag> GetAll();
        Tag GetById(int id);
        void SaveChange();
    }
    public class TagService: ITagService
    {
        private ITagRepository _tagRepository;
        private IUnitOfWork _unitOfWork;
        public TagService(ITagRepository tagRepository, IUnitOfWork unitOfWork)
        {
            this._tagRepository = tagRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Tag tag)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tag GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}

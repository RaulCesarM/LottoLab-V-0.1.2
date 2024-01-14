
using LottoLab.DTO;
using LottoLab.Interfaces;
using LottoLab.Models;

namespace LottoLab.Services
{
    public class LotoFacilService : ILotoFacilServices
    {
        private readonly ILotoFacilRepository _Repository;
        public LotoFacilService( ILotoFacilRepository Repository)
        {
             _Repository = Repository;
        }
        public LotoFacilDTO GetById(int id)
        {
             return new LotoFacilDTO(_Repository.GetById(id));
        }

        public int GetFirst()
        {
             return _Repository.GetFirst();
        }

        public int GetLast()
        {
            return _Repository.GetLast();
        }

       

        public void Insert(LotoFacilDTO entity)
        {
            var lotoFacil = new LotoFacil(entity);
            _Repository.Insert(lotoFacil);
        }

        ////////////////////////////////////////////////////////////////
         public int GetTotal()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LotoFacilDTO entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
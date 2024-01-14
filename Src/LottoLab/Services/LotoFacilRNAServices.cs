using LottoLab.DTO;
using LottoLab.Interfaces;
using LottoLab.Models;

namespace LottoLab.Services
{
    public class LotoFacilRNAServices : ILotoFacilRNAServices
    {
        private readonly ILotoFacilRNARepository _Repository;
        public LotoFacilRNAServices(ILotoFacilRNARepository Repository)
        {
            _Repository = Repository;
        }
        public LotoFacilRNADTO GetById(int id)
        {
            return new LotoFacilRNADTO(_Repository.GetById(id));
        }

        public int GetFirst()
        {
            return _Repository.GetFirst();
        }

        public int GetLast()
        {
            return _Repository.GetLast();
        }

        public void Insert(LotoFacilRNADTO entity)
        {
            var lotoFacilRNA = new LotoFacilRNA(entity);
            _Repository.Insert(lotoFacilRNA);
        }

        public IQueryable<LotoFacilRNA> GetQuerable(Pagination pagination)
        {
            return _Repository.GetQuerable(pagination);
        }

        public IList<LotoFacilRNA> GetLastRecords(int count)
    {
        IList<LotoFacilRNA> listaPadroes = _Repository.GetLastRecords(count);
        return listaPadroes;
    }

        //////////////////////////////////////////////////////////////////////////////////////////////
        public int GetTotal()
        {
            return _Repository.GetTotal();
        }


        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LotoFacilRNADTO entity, int id)
        {
            throw new NotImplementedException();
        }


    }
}
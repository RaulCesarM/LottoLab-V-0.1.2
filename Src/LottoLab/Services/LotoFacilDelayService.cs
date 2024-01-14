using LottoLab.DTO;
using LottoLab.Interfaces;
using LottoLab.Models;

namespace LottoLab.Services
{
    public class LotoFacilDelayService : ILotoFacilDelayService
    {
         private readonly ILotoFacilDelayRepository _Repository;
         public LotoFacilDelayService(ILotoFacilDelayRepository Repository)
         {
             _Repository = Repository;
         }
        public LotoFacilDelayDTO GetById(int id)
        {
             return new LotoFacilDelayDTO(_Repository.GetById(id));
        }

        public int GetFirst()
        {
             return _Repository.GetFirst();
        }

        public int GetLast()
        {
            return _Repository.GetLast();
        }

         public void Insert(LotoFacilDelayDTO entity)
        {
             var lotoFacilDelay = new LotoFacilDelay(entity);
            _Repository.Insert(lotoFacilDelay);
        }

        ///////////////////////////////////////////////////////

        public int GetTotal()
        {
            throw new NotImplementedException();
        }



        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LotoFacilDelayDTO entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
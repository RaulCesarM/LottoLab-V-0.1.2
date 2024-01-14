using LottoLab.DTO;
using LottoLab.Interfaces;
using LottoLab.Models;


namespace LottoLab.Services
{
    public class LotoFacilMostDawnServices : ILotoFacilMostDawnServices
    {
        
         private readonly ILotoFacilMostDawnRepository _Repository;
         public LotoFacilMostDawnServices(ILotoFacilMostDawnRepository Repository)
         {
            _Repository = Repository;
         }
        public LotoFacilMostDownDTO GetById(int id)
        {
             return new LotoFacilMostDownDTO(_Repository.GetById(id));
        }

        public int GetFirst()
        {
             return _Repository.GetFirst();
        }

        public int GetLast()
        {
            return _Repository.GetLast();
        }

        public int GetTotal()
        {
            throw new NotImplementedException();
        }

        public void Insert(LotoFacilMostDownDTO entity)
        {
             var lotoFacilMostDown = new LotoFacilMostDown(entity);
            _Repository.Insert(lotoFacilMostDown);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LotoFacilMostDownDTO entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
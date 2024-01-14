
using LottoLab.DTO;
using LottoLab.Models;

namespace LottoLab.Interfaces
{
    public interface ILotoFacilRNAServices
    {
        LotoFacilRNADTO GetById(int id);
        int GetTotal();         
        void Insert(LotoFacilRNADTO entity);
        void Remove(int  id);
        void Update(LotoFacilRNADTO entity, int id);
        int GetFirst();
        int GetLast();
         public IList<LotoFacilRNA> GetLastRecords(int count);
        public  IQueryable<LotoFacilRNA> GetQuerable(Pagination pagination);
    }
}
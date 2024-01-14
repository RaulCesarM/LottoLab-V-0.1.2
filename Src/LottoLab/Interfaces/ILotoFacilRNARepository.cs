
using LottoLab.DTO;
using LottoLab.Models;

namespace LottoLab.Interfaces
{
    public interface ILotoFacilRNARepository
    {
         LotoFacilRNA GetById(int id);
        int GetTotal();         
        void Insert(LotoFacilRNA entity);
        void Remove(int  id);
        void Update(LotoFacilRNA entity, int id);
        int GetFirst();
        int GetLast();
         public IList<LotoFacilRNA> GetLastRecords(int count);
        public IQueryable<LotoFacilRNA> GetQuerable(Pagination pagination);
    }
}
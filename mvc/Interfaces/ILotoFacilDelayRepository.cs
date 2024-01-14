using LottoLab.Models;

namespace LottoLab.Interfaces
{
    public interface ILotoFacilDelayRepository
    {
         LotoFacilDelay GetById(int id);
        int GetTotal();         
        void Insert(LotoFacilDelay entity);
        void Remove(int  id);
        void Update(LotoFacilDelay entity, int id);
        int GetFirst();
        int GetLast();
    }
}

using LottoLab.Models;

namespace LottoLab.Interfaces
{
    public interface ILotoFacilMostDawnRepository
    {
        LotoFacilMostDown GetById(int id);
        int GetTotal();         
        void Insert(LotoFacilMostDown entity);
        void Remove(int  id);
        void Update(LotoFacilMostDown entity, int id);
        int GetFirst();
        int GetLast();
    }
}
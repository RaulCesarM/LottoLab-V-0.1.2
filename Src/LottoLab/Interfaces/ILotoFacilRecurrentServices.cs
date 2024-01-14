
using LottoLab.DTO;

namespace LottoLab.Interfaces
{
    public interface ILotoFacilRecurrentServices
    {
        LotoFacilRecurrentDTO GetById(int id);
        int GetTotal();         
        void Insert(LotoFacilRecurrentDTO entity);
        void Remove(int  id);
        void Update(LotoFacilRecurrentDTO entity, int id);
        int GetFirst();
        int GetLast();
    }
}
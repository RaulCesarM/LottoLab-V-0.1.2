using LottoLab.DTO;

namespace LottoLab.Interfaces
{
    public interface ILotoFacilDelayService 
    {
        LotoFacilDelayDTO GetById(int id);
        int GetTotal();         
        void Insert(LotoFacilDelayDTO entity);
        void Remove(int  id);
        void Update(LotoFacilDelayDTO entity, int id);
        int GetFirst();
        int GetLast();
    }
}
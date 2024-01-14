using LottoLab.DTO;

namespace LottoLab.Interfaces
{
    public interface ILotoFacilMostDawnServices
    {
        LotoFacilMostDownDTO GetById(int id);
        int GetTotal();         
        void Insert(LotoFacilMostDownDTO entity);
        void Remove(int  id);
        void Update(LotoFacilMostDownDTO entity, int id);
        int GetFirst();
        int GetLast();
       
    }
}
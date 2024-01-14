using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LottoLab.Models;

namespace LottoLab.Interfaces
{
    public interface ILotoFacilRecurrentRepository
    {
        LotoFacilRecurrent GetById(int id);
        int GetTotal();         
        void Insert(LotoFacilRecurrent entity);
        void Remove(int  id);
        void Update(LotoFacilRecurrent entity, int id);
        int GetFirst();
        int GetLast();
    }
}
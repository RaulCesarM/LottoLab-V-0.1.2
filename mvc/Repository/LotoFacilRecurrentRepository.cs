using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LottoLab.Context;
using LottoLab.Interfaces;
using LottoLab.Models;

namespace LottoLab.Repository
{
    public class LotoFacilRecurrentRepository : ILotoFacilRecurrentRepository
    {

        private readonly LottoLabContext _context;

        public LotoFacilRecurrentRepository(LottoLabContext context)
        {
            _context = context;
        }
        
        public LotoFacilRecurrent GetById(int id)
        {
            return _context.LotoFacilRecurrentContext.Find(id);
        }

        public int GetFirst()
        {
           var first = _context.LotoFacilRecurrentContext.FirstOrDefault();
            if (first == null)
            {
                first.Concurso = 1;
            }
            return first.Id;
        }

        public int GetLast()
        {
            var latest = _context.LotoFacilRecurrentContext.OrderBy(x => x).LastOrDefault();
            if (latest == null)
            {
                return 0;
            }
            return latest.Concurso;
        }

        
        public void Insert(LotoFacilRecurrent entity)
        {
            _context.LotoFacilRecurrentContext.Add(entity);
            _context.SaveChanges();
        }

        ///////////////////////////////////////////////

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LotoFacilRecurrent entity, int id)
        {
            throw new NotImplementedException();
        }

        public int GetTotal()
        {
            throw new NotImplementedException();
        }

    }
}
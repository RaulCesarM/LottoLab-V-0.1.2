using LottoLab.Context;
using LottoLab.Interfaces;
using LottoLab.Models;

namespace LottoLab.Repository
{
    public class LotoFacilDelayRepository : ILotoFacilDelayRepository
    {
         private readonly LottoLabContext _context;
         public LotoFacilDelayRepository(LottoLabContext context)
         {
             _context = context;
         }
        public LotoFacilDelay GetById(int id)
        {
           
            return _context.LotoFacilDelayContext.Find(id);
        }

        public int GetFirst()
        {
            var first = _context.LotoFacilDelayContext.FirstOrDefault();
            if (first == null)
            {
                first.Concurso = 1;
            }
            return first.Id;
        }

        public int GetLast()
        {
            var latest = _context.LotoFacilDelayContext.OrderBy(x => x).LastOrDefault();
            if (latest == null)
            {
                return 0;
            }
            return latest.Concurso;
        }

     
        public void Insert(LotoFacilDelay entity)
        {
             _context.LotoFacilDelayContext.Add(entity);
            _context.SaveChanges();
        }
           public int GetTotal()
        {
            throw new NotImplementedException();
        }


        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LotoFacilDelay entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
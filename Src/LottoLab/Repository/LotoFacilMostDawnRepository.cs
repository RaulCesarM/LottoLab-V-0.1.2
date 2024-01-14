using LottoLab.Context;
using LottoLab.Interfaces;
using LottoLab.Models;

namespace LottoLab.Repository
{
    public class LotoFacilMostDawnRepository : ILotoFacilMostDawnRepository
    {
         private readonly LottoLabContext _context;

         public LotoFacilMostDawnRepository(LottoLabContext context)
         {
             _context = context;
         }
        public LotoFacilMostDown GetById(int id)
        {
            return _context.LotoFacilMostDownContext.Find(id);
        }

        public int GetFirst()
        {
            var first = _context.LotoFacilMostDownContext.FirstOrDefault();
            if (first == null)
            {
                first.Concurso = 1;
            }
            return first.Id;
        }

        public int GetLast()
        {
            var latest = _context.LotoFacilMostDownContext.OrderBy(x => x).LastOrDefault();
            if (latest == null)
            {
                return 0;
            }
            return latest.Concurso;
        }

        public int GetTotal()
        {
            throw new NotImplementedException();
        }

        public void Insert(LotoFacilMostDown entity)
        {
            _context.LotoFacilMostDownContext.Add(entity);
            _context.SaveChanges();
        }


        ///---------------------------------------------/

      

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LotoFacilMostDown entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
using LottoLab.Context;
using LottoLab.Interfaces;
using LottoLab.Models;
namespace LottoLab.Repository
{
    public class LotoFacilRepository : ILotoFacilRepository
    {
        private readonly LottoLabContext _context;
        public LotoFacilRepository(LottoLabContext context)
        {
             _context = context;
        }
        public LotoFacil GetById(int id)
        {
            return _context.LotoFacilContext.Find(id);
        }
        public int GetFirst()
        {
            var first = _context.LotoFacilContext.FirstOrDefault();
            if (first == null)
            {
                first.Concurso = 1;
            }
            return first.Id;
        }
        public int GetLast()
        {
             var latest = _context.LotoFacilContext.OrderBy(x => x).LastOrDefault();
            if (latest == null)
            {
                return 0;
            }
            return latest.Concurso;
        }   
        public void Insert(LotoFacil entity)
        {
            _context.LotoFacilContext.Add(entity);
            _context.SaveChanges();
        }
        ///////////////////////////////////////////////////////////////////////////
         public int GetTotal()
        {
            throw new NotImplementedException();
        }
        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(LotoFacil entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
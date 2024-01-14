using LottoLab.Context;
using LottoLab.Interfaces;
using LottoLab.Models;

namespace LottoLab.Repository
{
    public class LotoFacilRNARepository : ILotoFacilRNARepository
    {
        private readonly LottoLabContext _context;
        public LotoFacilRNARepository(LottoLabContext context)
        {
            _context = context;
        }

        public LotoFacilRNA GetById(int id)
        {
            return _context.LotoFacilRNAContext.Find(id);
        }

        public int GetFirst()
        {
            var first = _context.LotoFacilRNAContext.FirstOrDefault();
            if (first == null)
            {
                first.Concurso = 1;
            }
            return first.Id;
        }

        public int GetLast()
        {
            var latest = _context.LotoFacilRNAContext.OrderBy(x => x).LastOrDefault();
            if (latest == null)
            {
                return 0;
            }
            return latest.Concurso;
        }

        public void Insert(LotoFacilRNA entity)
        {
            _context.LotoFacilRNAContext.Add(entity);
            _context.SaveChanges();
        }

        public IList<LotoFacilRNA> GetLastRecords(int count)
        {
           
            IList<LotoFacilRNA> listaPadroes = new List<LotoFacilRNA>();
                listaPadroes = _context.LotoFacilRNAContext.OrderByDescending(x => x.Id).Take(count).ToList();
            return listaPadroes;
        }





        /////////////////////////////////////////////////////

        public int GetTotal()
        {
            return _context.LotoFacilRNAContext.Count();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LotoFacilRNA entity, int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<LotoFacilRNA> GetQuerable(Pagination pagination)
        {
            var query = _context.Set<LotoFacilRNA>()
                       .Take(pagination.Take)
                       .Skip(pagination.Skip);

            return query.AsQueryable();
        }
    }
}
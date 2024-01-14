
namespace LottoLab.Interfaces
{
    public interface ICommomServices<TEntity, Tkey> where TEntity : class 
    {
        TEntity GetById(Tkey id);
        int GetTotal();         
        void Insert(TEntity entity);
        void Remove(Tkey  id);
        void Update(TEntity entity, Tkey id);
        int GetFirst();
        int GetLast();
    }
}
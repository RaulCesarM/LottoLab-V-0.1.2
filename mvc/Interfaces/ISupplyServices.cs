namespace LottoLab.Interfaces
{
    public interface ISupplyServices
    {
        Task<int>  checkLastDrawOnWeb();
        Task populateDatabaseWithNewDraws(int lastDrawDB);     
        
    }
}
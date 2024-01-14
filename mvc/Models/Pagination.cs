namespace LottoLab.Models
{
    public class Pagination
    {
        public Pagination()
        {
        }

        public Pagination(int take, int skip)
        {
            Take = take;
            Skip = skip;
        }

        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
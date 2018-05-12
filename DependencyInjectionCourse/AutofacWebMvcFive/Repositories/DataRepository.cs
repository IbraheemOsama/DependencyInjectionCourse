namespace AutofacWebMvcFive.Repositories
{
    public interface IDataRepository
    {
        string GetData();
        int Count { get; set; }
    }

    public class DataRepository : IDataRepository
    {
        public DataRepository()
        {
            Count = 0;
        }
        public string GetData()
        {
            Count++;
            return "Data";
        }

        public int Count { get; set; }
    }
}
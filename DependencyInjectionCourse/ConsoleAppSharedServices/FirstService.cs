namespace ConsoleAppSharedServices
{
    public interface IFirstService
    {
        int Count { get; set; }
        int IncrementAndReturnCount();
    }

    public class FirstService : IFirstService
    {
        public int Count { get; set; }

        public FirstService()
        {
            Count = 0;
        }

        public int IncrementAndReturnCount()
        {
            return ++Count;
        }
    }
}

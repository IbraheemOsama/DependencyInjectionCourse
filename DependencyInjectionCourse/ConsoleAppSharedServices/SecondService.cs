namespace ConsoleAppSharedServices
{
    public interface ISecondService
    {
        int ReturnCount();
    }

    public class SecondService : ISecondService
    {
        private readonly IFirstService _firstService;
        public SecondService(IFirstService firstService)
        {
            _firstService = firstService;
        }

        public int ReturnCount()
        {
            return _firstService.Count;
        }
    }
}

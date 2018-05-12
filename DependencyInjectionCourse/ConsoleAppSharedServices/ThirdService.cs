using Ninject;

namespace ConsoleAppSharedServices
{
    public class ThirdService : ISecondService
    {
        [Inject]
        public IFirstService FirstService { private get; set; }

        public int ReturnCount()
        {
            return FirstService.Count + 1;
        }
    }
}
namespace DependencyInjectionTypes
{
    public class ServiceAFunction
    {
        public string GetResult(IRepository repository)
        {
            return repository.GetData();
        }
    }
}

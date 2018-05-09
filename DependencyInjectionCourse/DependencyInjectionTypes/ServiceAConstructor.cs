namespace DependencyInjectionTypes
{
    public class ServiceAConstructor
    {
        private readonly IRepository _repository;

        public ServiceAConstructor(IRepository repository)
        {
            _repository = repository;
        }

        public string GetResult()
        {
            return _repository.GetData();
        }
    }
}

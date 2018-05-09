namespace DependencyInjectionTypes
{
    public class ServiceAProperty
    {
        public IRepository Repository { get; set; }

        public string GetResult()
        {
            return Repository.GetData();
        }
    }
}

namespace DependencyInjectionTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorInjection();
            FunctionInjection();
            PropertyInjection();
        }

        private static void ConstructorInjection()
        {
            IRepository repoOne;
            if (true)
            {
                repoOne = new MongoDbRepository();
            }
            else
            {
                repoOne = new SqlServerDbRepository();
            }
            var serviceAConstructor = new ServiceAConstructor(repoOne);
            serviceAConstructor.GetResult();
        }

        private static void FunctionInjection()
        {
            IRepository repoOne;
            if (true)
            {
                repoOne = new MongoDbRepository();
            }
            else
            {
                repoOne = new SqlServerDbRepository();
            }

            var serviceAFunction = new ServiceAFunction();
            serviceAFunction.GetResult(repoOne);
        }

        private static void PropertyInjection()
        {
            IRepository repoOne;
            var serviceAProperty = new ServiceAProperty();
            if (false)
            {
                repoOne = new SqlServerDbRepository();
            }
            else
            {
                repoOne = new TestRepository();
            }
            serviceAProperty.Repository = repoOne;
            serviceAProperty.GetResult();
        }
    }
}

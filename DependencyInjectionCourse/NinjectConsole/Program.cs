using System;
using ConsoleAppSharedServices;
using Ninject;

namespace NinjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewInstance();
            //Singleton();
            //SecondService();
            ThirdService();
        }

        private static void NewInstance()
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IFirstService>().To<FirstService>();

                var firstServiceNewInstance = kernel.Get<IFirstService>();
                firstServiceNewInstance.IncrementAndReturnCount();

                // Resolve Again
                firstServiceNewInstance = kernel.Get<IFirstService>();
                firstServiceNewInstance.IncrementAndReturnCount();

                Console.WriteLine(firstServiceNewInstance.Count);
                Console.WriteLine("Press any key to exit !!");
                Console.ReadLine();
            }
        }

        private static void Singleton()
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IFirstService>().To<FirstService>().InSingletonScope();
                var firstServiceNewInstance = kernel.Get<IFirstService>();
                firstServiceNewInstance.IncrementAndReturnCount();

                // Resolve Again
                firstServiceNewInstance = kernel.Get<IFirstService>();
                firstServiceNewInstance.IncrementAndReturnCount();

                Console.WriteLine(firstServiceNewInstance.Count);
                Console.WriteLine("Press any key to exit !!");
                Console.ReadLine();
            }
        }

        // Constructor Injection.
        private static void SecondService()
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IFirstService>().To<FirstService>().InSingletonScope();
                kernel.Bind<ISecondService>().To<SecondService>();

                var firstServiceNewInstance = kernel.Get<IFirstService>();
                firstServiceNewInstance.IncrementAndReturnCount();

                firstServiceNewInstance = kernel.Get<IFirstService>();
                firstServiceNewInstance.IncrementAndReturnCount();

                var secondService = kernel.Get<ISecondService>();

                Console.WriteLine(secondService.ReturnCount());
                Console.WriteLine("Press any key to exit !!");
                Console.ReadLine();
            }
        }

        // Property Injection
        private static void ThirdService()
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IFirstService>().To<FirstService>().InSingletonScope();

                // Hint we're using ISecondService but we resloved the ThirdService
                // You can use similar scenario in testing.
                kernel.Bind<ISecondService>().To<ThirdService>();

                var firstServiceNewInstance = kernel.Get<IFirstService>();
                firstServiceNewInstance.IncrementAndReturnCount();

                firstServiceNewInstance = kernel.Get<IFirstService>();
                firstServiceNewInstance.IncrementAndReturnCount();

                var thirdService = kernel.Get<ISecondService>();

                Console.WriteLine(thirdService.ReturnCount());
                Console.WriteLine("Press any key to exit !!");
                Console.ReadLine();
            }
        }
    }
}

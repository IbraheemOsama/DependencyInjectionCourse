using Autofac;
using AutofacWebMvcFive.Repositories;
using AutofacWebMvcFive.Utilities;

namespace AutofacWebMvcFive.Modules
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataRepository>().As<IDataRepository>().InstancePerRequest();
            builder.RegisterType<UserRepository>().AsImplementedInterfaces();
            builder.RegisterType<UserProvider>().As<IUserProvider>().SingleInstance();

            base.Load(builder);
        }
    }
}
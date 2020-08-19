using Application;
using Domain.Interfaces.AppServices;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Repository.Repositories;
using SimpleInjector;

namespace IoC
{
    public static class ConfigurationIoC
    {
        public static Container Register()
        {
            var container = new Container();

            container.Register<IBookRepository, BookRepository>(Lifestyle.Singleton);
            container.Register<ICategoryRepository, CategoryRepository>(Lifestyle.Singleton);

            container.Register<IBookService, BookService>(Lifestyle.Singleton);
            container.Register<ICategoryService, CategoryService>(Lifestyle.Singleton);

            container.Register<IBookAppService, BookAppService>(Lifestyle.Singleton);
            container.Register<ICategoryAppService, CategoryAppService>(Lifestyle.Singleton);

            container.Verify();

            return container;
        }
    }
}

using IoC;
using SimpleInjector;

namespace LibraryAPI.Helper
{
    internal static class SystemHelper
    {
        public static Container Container { get; private set; } = ConfigurationIoC.Register();
    }
}

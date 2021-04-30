using Prism.Ioc;
using System.Windows;
using Alacron.Vitality.Views;
using Prism.Modularity;
using Alacron.Supplements;

namespace Alacron.Vitality
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new DirectoryModuleCatalog() { ModulePath = @".\Modules" };
        //}

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<SupplementsModule>();
        }
    }
}

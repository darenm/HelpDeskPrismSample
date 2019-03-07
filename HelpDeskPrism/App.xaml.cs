using HelpDeskPrism.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace HelpDeskPrism
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

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            moduleCatalog.AddModule(typeof(Home.HomeModule));
            moduleCatalog.AddModule(typeof(MyIT.MyITModule));
            moduleCatalog.AddModule(typeof(Assets.AssetsModule));
            moduleCatalog.AddModule(typeof(ReportCenter.ReportCenterModule));
            moduleCatalog.AddModule(typeof(Purchasing.PurchasingModule));
        }
    }
}

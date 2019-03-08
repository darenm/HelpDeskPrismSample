using HelpDeskPrism.Infrastructure;
using Home.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Home
{
    public class HomeModule : IModule
    {
        private IRegionManager _regionManager;

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager = containerProvider.Resolve<IRegionManager>();
            _regionManager.AddToRegion(RegionNames.TabBarRegion, new HomeShell());
            _regionManager.AddToRegion(HomeRegionNames.HomeNavRegion, new HomeNavView());
            _regionManager.AddToRegion(HomeRegionNames.HomeContentRegion, new HomeMainView());
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
using HelpDeskPrism.Infrastructure;
using MyIT.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MyIT
{
    public class MyITModule : IModule
    {
        private IRegionManager _regionManager;

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager = containerProvider.Resolve<IRegionManager>();
            _regionManager.AddToRegion(RegionNames.TabBarRegion, new ViewA());
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
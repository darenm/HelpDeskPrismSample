using Assets.Views;
using HelpDeskPrism.Infrastructure;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Assets
{
    public class AssetsModule : IModule
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
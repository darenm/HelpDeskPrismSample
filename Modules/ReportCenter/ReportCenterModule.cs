using HelpDeskPrism.Infrastructure;
using ReportCenter.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ReportCenter
{
    public class ReportCenterModule : IModule
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
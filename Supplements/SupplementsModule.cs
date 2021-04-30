using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Alacron.Supplements.Views;

namespace Alacron.Supplements
{
    public class SupplementsModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public SupplementsModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public string Uri => "ContentRegion";

        public void OnInitialized(IContainerProvider containerProvider)
        {
            // View discovery
            //_regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
            // View Injection
            IRegion region = _regionManager.Regions[Uri];
            var view1 = containerProvider.Resolve<ViewA>();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
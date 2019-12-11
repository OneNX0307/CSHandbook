using Prism.Demo.QuickStart.New.Views;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prism.Demo.QuickStart.New
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IContainerExtension _container;
        IRegionManager _regionManager;

        public MainWindow(IContainerExtension container,IRegionManager regionManager)
        {
            InitializeComponent();
            this._container = container;
            this._regionManager = regionManager;
            //View discovery
            //regionManager.RegisterViewWithRegion("LeftTopRegion", typeof(DemoAView));
            //regionManager.RegisterViewWithRegion("LeftCenterRegion", typeof(DemoAView));
            //View inject
            var view = _container.Resolve<DemoAView>();
            IRegion region = _regionManager.Regions["LeftCenterRegion"];
            region.Add(view);
        }
    }
}

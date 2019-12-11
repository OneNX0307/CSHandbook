using Microsoft.Practices.Unity;
using Prism.Demo.QuickStart.Legacy.ViewModels;
using Prism.Mef;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace Prism.Demo.QuickStart.Legacy
{
    public class Bootstrapper : UnityBootstrapper//MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
        }
    }
}

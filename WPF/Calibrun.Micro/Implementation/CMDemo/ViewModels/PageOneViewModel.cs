using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CMDemo.ViewModels
{
    public class PageOneViewModel : Screen
    {
        public override void CanClose(Action<bool> callback)
        {
            callback(true);
        }

        public override void TryClose(bool? dialogResult = null)
        {
            
        }
    }
}

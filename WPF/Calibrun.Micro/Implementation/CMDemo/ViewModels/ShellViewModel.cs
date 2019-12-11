using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDemo.ViewModels
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {
        int count = 1;

        public void OpenTab()
        {
            ActivateItem(new TabViewModel
            {
                DisplayName = "Tab " + count++
            });
        }
    }
}

using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prism.Demo.QuickStart.Legacy.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public DelegateCommand ShowCommand { get; set; }
        public string BtnName { get; set; } = "Alfred";
        public ShellViewModel()
        {
            ShowCommand = new DelegateCommand(ShowIt, CanShowIt);
        }

        public void ShowIt()
        {
            MessageBox.Show("SMEE");
        }

        public bool CanShowIt()
        {
            return true;
        }
    }
}

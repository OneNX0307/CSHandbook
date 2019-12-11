using Caliburn.Micro.Demo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Caliburn.Micro.Demo.ViewModels
{
    public class ShellViewModel
    {
        #region Properties
        public int Id { get; set; } = 1;
        #endregion
        #region Cotr
        public ShellViewModel()
        {

        }
        #endregion

        #region EventHandler
        public void ThisClick(object @this)
        {
            MessageBox.Show($"The method is invoke in {((ShellViewModel)@this).ToString()}");
        }

        public void SourceClick(object source)
        { 
            MessageBox.Show($"The message from {((Button)source).Name}");
        }

        public void ViewClick(object view)
        { 
            MessageBox.Show($"The action is invoke from view {((ShellView)view).Name}");
        }

        public void EventArgsClick(RoutedEventArgs e)
        {
            MessageBox.Show($"The event args passed is {e.ToString()}");
        }

        public void DataContextClick(object dataContext)
        { 
            MessageBox.Show($"The dataContext is {dataContext.ToString()}");
        }

        public void ExecutionContextClick(object executionContext)
        { 
            MessageBox.Show($"The executionContext is {executionContext.ToString()}");
        }
        #endregion
    }
}

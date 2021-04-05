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

namespace ONEN
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.ctlRegion.MouseLeftButtonDown += (o, e) => { DragMove(); };
		}

		private void DoMin(object sender, RoutedEventArgs e)
		{
		}

		private void DoMax(object sender, RoutedEventArgs e)
		{

		}

		private void DoClose(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void MenuClick(object sender, RoutedEventArgs e)
		{
			Button realSender = (Button)sender;
			Grid readParent = (Grid)realSender.Parent;
			if (250 == readParent.ActualWidth)
			{
				this.LeftSide.Width = new GridLength(40);
				this.UserName.Visibility = Visibility.Hidden;
				return;
			}
			this.LeftSide.Width = new GridLength(250);
			this.UserName.Visibility = Visibility.Visible;
		}
	}
}

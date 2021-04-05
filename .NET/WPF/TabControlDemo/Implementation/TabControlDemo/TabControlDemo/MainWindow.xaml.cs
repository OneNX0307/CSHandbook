using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using TabControlDemo.Model;

namespace TabControlDemo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public MainWindow()
		{
			InitializeComponent();
		}

		private ObservableCollection<Department> departments;

		public ObservableCollection<Department> Departments
		{
			get
			{
				if (departments == null)
				{
					departments = new ObservableCollection<Department>();
				}
				return departments;
			}

		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Department d1 = new Department { Name = "IT部" };
			d1.Employees.Add(new Employee() { EmployeeName = "张三", Sex = "男", Age = 30, Title = "IT部部门经理" });
			d1.Employees.Add(new Employee() { EmployeeName = "李四", Sex = "男", Age = 28, Title = "高级工程师" });
			d1.Employees.Add(new Employee() { EmployeeName = "王五", Sex = "男", Age = 23, Title = "软件工程师" });
			d1.Employees.Add(new Employee() { EmployeeName = "小丽", Sex = "女", Age = 19, Title = "助理工程师" });

			Department d2 = new Department { Name = "采购部" };
			d2.Employees.Add(new Employee() { EmployeeName = "孙钱", Sex = "男", Age = 30, Title = "采购部部门经理" });
			d2.Employees.Add(new Employee() { EmployeeName = "胡言", Sex = "男", Age = 28, Title = "采购员" });
			d2.Employees.Add(new Employee() { EmployeeName = "梁雨", Sex = "女", Age = 23, Title = "采购员" });

			Department d3 = new Department { Name = "销售部" };
			d3.Employees.Add(new Employee() { EmployeeName = "刘明", Sex = "男", Age = 30, Title = "销售部部门经理" });
			d3.Employees.Add(new Employee() { EmployeeName = "霍奇", Sex = "男", Age = 28, Title = "销售员" });
			d3.Employees.Add(new Employee() { EmployeeName = "何军", Sex = "女", Age = 23, Title = "销售员" });

			this.Departments.Add(d1);
			this.Departments.Add(d2);
			this.Departments.Add(d3);
		}
	}
}

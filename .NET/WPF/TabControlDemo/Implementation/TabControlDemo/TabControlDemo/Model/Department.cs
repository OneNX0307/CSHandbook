using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabControlDemo.Model
{
	public class Department : NotificationObject
	{
		#region Fileds
		private string name;
		private ObservableCollection<Employee> employees;
		#endregion

		#region Properties
		public string Name
		{
			get { return name; }
			set
			{
				if (value != name)
				{
					name = value;
					OnPropertyChanged("Name");
				}
			}
		}
		public ObservableCollection<Employee> Employees
		{
			get
			{
				if (employees == null)
				{
					employees = new ObservableCollection<Employee>();
				}
				return employees;
			}

		}
		#endregion


	}
}

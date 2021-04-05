using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabControlDemo.Model
{
	public class Employee : NotificationObject
	{
		#region Filed
		private string employeeName;
		private string sex;
		private int age;
		private string title;
		#endregion

		#region Properties
		public string EmployeeName
		{
			get { return employeeName; }
			set
			{
				if (value != employeeName)
				{
					employeeName = value;
					OnPropertyChanged("EmployeeName");
				}
			}
		}
		public string Sex
		{
			get { return sex; }
			set
			{
				if (value != sex)
				{
					sex = value;
					OnPropertyChanged("Sex");
				}
			}
		}
		public int Age
		{
			get { return age; }
			set
			{
				if (value != age)
				{
					age = value;
					OnPropertyChanged("Age");
				}
			}
		}
		public string Title
		{
			get { return title; }
			set
			{
				if (value != title)
				{
					title = value;
					OnPropertyChanged("Title");
				}
			}
		}
		#endregion
	}
}

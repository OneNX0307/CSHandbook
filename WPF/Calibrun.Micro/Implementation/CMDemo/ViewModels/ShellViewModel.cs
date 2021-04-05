using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDemo.ViewModels
{
    public class ShellViewModel : Screen
    {
		public ShellViewModel()
		{
			this.Students.Add(new Student() { ID = 1, Name = "A", Score = 100, Classes = new List<string>() { "H", "N"} });
			this.Students.Add(new Student() { ID = 2, Name = "B", Score = 100, Classes = new List<string>() { "G", "P"} });
			this.Students.Add(new Student() { ID = 3, Name = "C", Score = 100, Classes = new List<string>() { "S", "L"} });
			this.Students.Add(new Student() { ID = 4, Name = "D", Score = 100, Classes = new List<string>() { "T", "K"} });
		}

		public List<Student> Students { get; set; } = new List<Student>();
		
	}

	public class Student
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int Score { get; set; }
		public List<string> Classes { get; set; }
	}
}

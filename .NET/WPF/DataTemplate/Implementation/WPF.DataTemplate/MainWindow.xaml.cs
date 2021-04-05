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
using WPF.DataTemplate.Enum;
using WPF.DataTemplate.Model;

namespace WPF.DataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            List<Person> people = new List<Person>()
            {
                new Person(){Id = 1, Name = "爸爸", Gender = GenderEnum.Male, Age= 56, Phone = "1xx49xxx002" },
                new Person(){Id = 2, Name = "妈妈", Gender = GenderEnum.Female, Age= 56, Phone = "1xx39xxx540" },
                new Person(){Id = 3, Name = "小杉杉", Gender = GenderEnum.Female, Age= 27, Phone = "1xx40xxx387" },
                new Person(){Id = 4, Name = "我", Gender = GenderEnum.Male, Age= 28, Phone = "1xx16xxx831" },
            };
            this.personList.ItemsSource = people;
            this.personList.SelectedIndex = 0;
        }
    }
}

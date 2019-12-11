using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.DataTemplate.Enum;

namespace WPF.DataTemplate.Model
{
    public class Person
    {
        #region Fields
        private int id;
        private string name;
        private GenderEnum gender;
        private int age;
        private string phone;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public GenderEnum Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        #endregion

    }
}

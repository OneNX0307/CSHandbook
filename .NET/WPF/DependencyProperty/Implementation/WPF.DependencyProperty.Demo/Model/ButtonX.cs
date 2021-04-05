using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.DependencyPropertyDemo.Enum;

namespace WPF.DependencyPropertyDemo.Model
{
    public class ButtonX : DependencyObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private ShapeEnum shape;

        public ShapeEnum Shape
        {
            get { return shape; }
            set { shape = value; }
        }
    }
}

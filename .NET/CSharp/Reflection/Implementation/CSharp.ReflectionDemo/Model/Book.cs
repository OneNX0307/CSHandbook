using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ReflectionDemo.Model
{
    public class Book
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Book():this(default(int), string.Empty)
        {

        }

        public Book(int id) : this(id, string.Empty)
        {
            
        }

        public Book(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Batch
{
}
namespace Demo
{
    class Employee
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


        public int salary { get; set; }
        public int departmentId { get; private set; }
    }
}

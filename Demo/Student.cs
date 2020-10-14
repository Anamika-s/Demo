using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Student
    {
        int rn;
        public int Rn
        {
            get { return rn; }
            set {
            if (value < 0)
            rn = 0;
            else 
            rn = value; }
        }

        string name;
    public string Name
    {
        get { return name; }
       // set { name = value; }
    }
        string batch;
    public string Batch
    {
        get { return batch; }
        set { batch = value; }
    }
        public void GetDetails() { }
        public void DisplayDetails() { }
    }



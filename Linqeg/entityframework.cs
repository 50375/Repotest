using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqeg
{
     class entityframework
    {
        frameworkEntities1 db=new frameworkEntities1 ();
        public void displayemployee()
        {
             var res=from t in db.Employees
            select t;
           // var res1 = from t in db.Employees
                      //where t.salary >= 10000
                      //select t;
                      //var res=from t in db.Employees
                             // where t.empname.StartsWith("a")
                              //select t;
            foreach(var item in res)
            {
                Console.WriteLine(item.empid + ":" + item.empname + ":" + item.salary);
            }
        }
    }
}

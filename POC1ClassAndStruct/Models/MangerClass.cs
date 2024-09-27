using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC1ClassAndStruct.Models
{
    internal class MangerClass : EmployeeClass
    {
        public override void PrintWork()
        {
            Console.WriteLine("Working");
        }
    }
}

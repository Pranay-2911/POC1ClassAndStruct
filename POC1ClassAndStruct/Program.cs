using POC1ClassAndStruct.Models;

namespace POC1ClassAndStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass employeeClass1 = new EmployeeClass();
            employeeClass1.EmployeeId = 5006;
            EmployeStruct employeStruct1 = new EmployeStruct();
            employeStruct1.EmployeeId = 5007;


            Console.WriteLine("=============POC for Classes Vs Structure =============");
            Console.WriteLine("\n\n");


            Console.WriteLine("============= 1 Access MModifier =============");
            Console.WriteLine();
            Console.WriteLine("Created two Object Class and Struct..");
            Console.WriteLine("The classs has Private by default to acces the data we have to implicitily convert into PUblic");
            Console.WriteLine("EMployee OF class " + employeeClass1.EmployeeId);
            Console.WriteLine("The struct are Public by default, we have implicitly convert into private if we want");
            Console.WriteLine("Employee Of Struct" + employeStruct1.EmployeeId);
            Console.WriteLine("\n\n");

            Console.WriteLine("============= 2 Memory Allocation =============");
            Console.WriteLine();
            Console.WriteLine("Object of class is storage in heap memory and the reference variable is store in stack.");
            Console.WriteLine("Struct are allocated in stack which improved its accessibility");
            Console.WriteLine("\n\n");


            Console.WriteLine("============= 3 Copying =============");
            Console.WriteLine();
            Console.WriteLine("For class");
            Console.WriteLine("When we pass object to another it will pass its reference\n" +
                "if any one object is change the changes in other will take place this also as Reference Type.");
            EmployeeClass employeeClass2 = employeeClass1;
            Console.WriteLine("Before Change in Class1");
            Console.WriteLine($"Employee id of class 1 {employeeClass1.EmployeeId}");
            Console.WriteLine($"Employee id of Class 2 {employeeClass2.EmployeeId}");
            employeeClass1.EmployeeId = 50008;
            Console.WriteLine("After Chnages");
            Console.WriteLine($"Employee id od class 1 {employeeClass1.EmployeeId}");
            Console.WriteLine($"Employee id of Class 2 {employeeClass2.EmployeeId}");
            Console.WriteLine();
            Console.WriteLine("For a Struct");
            Console.WriteLine("Where Struct are Value Type its means when we pass one struct to another then the copy of the value are passed.");
            EmployeStruct employeStruct2 = employeStruct1;
            Console.WriteLine("Before Change in Struc1");
            Console.WriteLine($"Employee id of Struct 1 {employeStruct1.EmployeeId}");
            Console.WriteLine($"Employee id of Struct 2 {employeStruct2.EmployeeId}");
            employeeClass1.EmployeeId = 50008;
            Console.WriteLine("After Chnages");
            Console.WriteLine($"Employee id of Struct 1 {employeStruct1.EmployeeId}");
            Console.WriteLine($"Employee id of Struct 2 {employeStruct2.EmployeeId}");
            Console.WriteLine("\n\n");

            Console.WriteLine("============ 4 Polymorphism =============");
            Console.WriteLine();
            Console.WriteLine("Classes support the polymorphism");


        }
    }
}

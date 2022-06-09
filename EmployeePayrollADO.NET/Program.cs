using EmployeePayrollADO.NET;
using System;
class Program
{
    static void Main(String[] args)
    {
        EmployeePayrollService empservice = new EmployeePayrollService();
        bool check = true;
        while (check)
        {
            Console.WriteLine("1. To Insert the Data in Data Base \n2.END");
            Console.WriteLine("Enter the Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmployeePayrollModel empPayrollModel = new EmployeePayrollModel();
                    empPayrollModel.Id = 6;
                    empPayrollModel.Name = "Adesh";
                    empPayrollModel.Salary = 70000;
                    empPayrollModel.StartDate = DateTime.Now;
                    empPayrollModel.Address = "Gurgoan";
                    empPayrollModel.PhoneNumber = "9454433030";
                    empPayrollModel.Gender = "M";
                    empPayrollModel.Basic_Pay = 700;
                    empPayrollModel.Deduction = 400;
                    empPayrollModel.Taxable_Pay = 500;
                    empPayrollModel.Tax = 300;
                    empPayrollModel.Income_Tax = 600;
                    empPayrollModel.Net_Pay = 2500;
                    empservice.AddEmp(empPayrollModel);
                    break;
                case 2:
                    check = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}


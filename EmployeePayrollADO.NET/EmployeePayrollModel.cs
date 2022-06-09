using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollADO.NET
{
    public class EmployeePayrollModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "StartDate is required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "phoneno is required.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Department  is required.")]
        public string Department { get; set; }
        public decimal Basic_Pay { get; set; }
        public decimal Deduction { get; set; }
        public decimal Taxable_Pay { get; set; }
        public decimal Tax { get; set; }
        public decimal Income_Tax { get; set; }
        public decimal Net_Pay { get; set; }
    }
}

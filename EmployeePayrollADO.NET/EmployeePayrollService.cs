using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollADO.NET
{
    public class EmployeePayrollService
    {
        private SqlConnection con;
        private void connection()
        {
            string connectingString = "Data Source=(localdb)\\MSSQLLocaldb;Initial Catalog=Payroll_Service";
            con = new SqlConnection(connectingString);
        }
        public string AddEmp(EmployeePayrollModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("SPAddNewEmpDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", obj.Id);
                com.Parameters.AddWithValue("@Name", obj.Name);
                com.Parameters.AddWithValue("@Salary", obj.Salary);
                com.Parameters.AddWithValue("@StartDate", obj.StartDate);
                com.Parameters.AddWithValue("@Gender", obj.Gender);
                com.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                com.Parameters.AddWithValue("@Address", obj.Address);
                com.Parameters.AddWithValue("@Pay", obj.Basic_Pay);
                com.Parameters.AddWithValue("@Deduction", obj.Deduction);
                com.Parameters.AddWithValue("@TaxablePay", obj.Taxable_Pay);
                com.Parameters.AddWithValue("@Tax", obj.Tax);
                com.Parameters.AddWithValue("@IncomeTax", obj.Income_Tax);
                com.Parameters.AddWithValue("@NetPay", obj.Net_Pay);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i >= 1)
                {
                    return "data Added";
                }
                else
                {
                    return "data not added";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.con.Close();
            }
        }
    }
}

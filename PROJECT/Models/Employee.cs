using MessagePack;
using Microsoft.EntityFrameworkCore;

namespace PROJECT.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? Empname { get; set; }
        public string? Empaddress { get; set; }
        public string? Empdesignation { get; set; }
        public System.DateTime EmpDOB { get; set; }
        public int Empcontactno { get; set; }
        public string? Empemail { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCodeFirstApproach_ss.Models
{
    [Table ("tblEmployee")]
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; } 
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public int Job { get; set; }
        public double Salary {  get; set; }
    }
}

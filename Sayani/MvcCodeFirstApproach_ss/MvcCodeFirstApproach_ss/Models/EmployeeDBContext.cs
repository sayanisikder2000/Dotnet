﻿using Microsoft.EntityFrameworkCore;

namespace MvcCodeFirstApproach_ss.Models
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options):base(options)
        {

        }
        public DbSet<EmployeeModel> employees {  get; set; }     
    }
}

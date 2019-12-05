using System;
using System.Collections.Generic;
using System.Text;
using ElectronicRedBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationZlogowaniem.Models;

namespace WebApplicationZlogowaniem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Child> Children { get; set; }
    }
}
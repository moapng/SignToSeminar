using Microsoft.EntityFrameworkCore;
using SignToSeminarBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignToSeminarBackEnd.Context
{
    public class STSDBContext : DbContext
    {

        public DbSet<SeminarModel> Seminars { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MOAAAAAAAAA\SQLEXPRESS01;Database=SignToSeminarDB;Trusted_Connection=True;");
        }
    }
}

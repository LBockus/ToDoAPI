using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAPI.Models;

namespace ToDoAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ToDo> ToDo { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}

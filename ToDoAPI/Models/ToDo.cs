using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAPI.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAPI.Data;
using ToDoAPI.Models;

namespace ToDoAPI.Services
{
    public class ToDoService
    {
        private DataContext _dataContext;
        public ToDoService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        


        public List<ToDo> GetAll()
        {
            return _dataContext.ToDo.ToList();
        }

        public ToDo GetById(int id)
        {
            return _dataContext.ToDo.FirstOrDefault(td => td.Id == id);
        }

        public void Create(string name)
        {
            var toDo = new ToDo();
            toDo.Name = name;
            _dataContext.Add(toDo);
            _dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dataContext.Remove(_dataContext.ToDo.Where(td => td.Id == id).FirstOrDefault());
            _dataContext.SaveChanges();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAPI.Data;
using ToDoAPI.Models;
using ToDoAPI.Services;

namespace ToDoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController: ControllerBase
    {
        private ToDoService _toDoService;

        public ToDoController(ToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet]
        public List<ToDo> GetAll()
        {
            return _toDoService.GetAll();
        }

        [HttpGet("{id}")]
        public ToDo GetById(int id)
        {
            return _toDoService.GetById(id);
        }

        [HttpPost]
        public void Create(string name)
        {
            _toDoService.Create(name);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _toDoService.Delete(id);
        }
    }
}

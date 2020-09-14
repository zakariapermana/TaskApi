using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddTodoRecord(TodoTask todo)
        {
            // add new todo to database
            _context.todo_task.Add(todo);
            _context.SaveChanges();
        }

        public void DeleteTodoRecord(string id)
        {
            // delete record of todo
            var entity = _context.todo_task.FirstOrDefault(t => t.id == id);
            _context.todo_task.Remove(entity);
            _context.SaveChanges();
        }

        public List<TodoTask> GetIncomingTodoRecord()
        {
            // using raw query to access the table where status != 'Done' and date >= now()
            return _context.todo_task.FromSqlRaw("SELECT * FROM todo_task where status!='Done' and date::date>=now()::date").ToList();
        }

        public List<TodoTask> GetTodoRecords()
        {
            // get list record of todo
            return _context.todo_task.ToList();
        }

        public TodoTask GetTodoSingleRecord(string id)
        {
            // get a todo record by id
            return _context.todo_task.FirstOrDefault(t => t.id == id);
        }

        public void MarkDoneTodoRecord(string id)
        {
            // get data from id and mark as 'Done'
            var data = _context.todo_task.FirstOrDefault(t => t.id == id);
            data.status = "Done";
            _context.todo_task.Update(data);
            _context.SaveChanges();
        }

        public void SetPercentTodoRecord(TodoTask todo)
        {
            // update percent of todo
            _context.todo_task.Update(todo);
            _context.SaveChanges();
        }

        public void UpdateTodoRecord(TodoTask todo)
        {
            // update todo record
            _context.todo_task.Update(todo);
            _context.SaveChanges();
        }
    }
}

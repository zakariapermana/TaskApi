using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services
{
    public interface IDataAccessProvider
    {
        void AddTodoRecord(TodoTask todo);
        void UpdateTodoRecord(TodoTask todo);
        void DeleteTodoRecord(string id);
        void SetPercentTodoRecord(TodoTask todo);
        void MarkDoneTodoRecord(string id);
        TodoTask GetTodoSingleRecord(string id);
        List<TodoTask> GetIncomingTodoRecord();
        List<TodoTask> GetTodoRecords();
    }
}

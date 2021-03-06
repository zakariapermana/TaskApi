﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Services;

namespace TaskApi.Controllers
{
    // rooute to access the controller
    [Route("api/todo")]
    public class TodoController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public TodoController(IDataAccessProvider dataAccessProvider)
        {
           _dataAccessProvider = dataAccessProvider;
        }

        // localhost:5001/api/todo
        [HttpGet]
        public IEnumerable<TodoTask> Get()
        {
            // get list todo item
            return _dataAccessProvider.GetTodoRecords();
        }

        // localhost:5001/api/todo
        [HttpPost]
        public IActionResult Create([FromBody] TodoTask todo)
        {
            if (ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
                // set unique id
                todo.id = obj.ToString();
                // save todo item
                _dataAccessProvider.AddTodoRecord(todo);
                return Ok();
            }
            return BadRequest();
        }

        // localhost:5001/api/todo/6449dacb-58be-4e79-ab66-aadf420c5e2d
        [HttpGet("{id}")]
        public TodoTask Details(string id)
        {
            // get details todo by id
            return _dataAccessProvider.GetTodoSingleRecord(id);
        }

        // localhost:5001/api/todo
        [HttpPut]
        public IActionResult Edit([FromBody] TodoTask todo)
        {
            if (ModelState.IsValid)
            {
                // update todo record
                _dataAccessProvider.UpdateTodoRecord(todo);
                return Ok();
            }
            return BadRequest();
        }

        // localhost:5001/api/todo/1
        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(string id)
        {
            var data = _dataAccessProvider.GetTodoSingleRecord(id);
            // check if the record is exist
            if (data == null)
            {
                return NotFound();
            }
            // then delete record 
            _dataAccessProvider.DeleteTodoRecord(id);
            return Ok();
        }

        //create new route localhost:5001/api/todo/1/mark-done
        [Route("{id}/mark-done")]
        public IActionResult MarkDone(string id)
        {
            var data = _dataAccessProvider.GetTodoSingleRecord(id);
            // check if the record is exist
            if (data == null)
            {
                return NotFound();
            }
            // then mark as 'Done'
            _dataAccessProvider.MarkDoneTodoRecord(id);
            return Ok();
        }

        //create new route localhost:5001/api/todo/1/percent
        [Route("{id}/percent")]
        public IActionResult PercentComplete(string id, [FromBody] TodoTask todo)
        {
            var data = _dataAccessProvider.GetTodoSingleRecord(id);
            // check if the record is exist
            if (data == null)
            {
                return NotFound();
            }
            // then set percent
            data.complete = todo.complete;
            _dataAccessProvider.SetPercentTodoRecord(data);
            return Ok();
        }

        //create new route localhost:5001/api/todo/incoming
        [Route("/api/todo/incoming")]
        public List<TodoTask> Incoming()
        {
            return _dataAccessProvider.GetIncomingTodoRecord();
        }
    }
}

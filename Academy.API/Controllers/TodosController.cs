using Acadamy.Core.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Academy.API.Controllers
{
    [RoutePrefix("api/todos")]
    public class TodosController : ApiController
    {
        private readonly ITodosService _todoService; 

        public TodosController(ITodosService todosService)
        {
            _todoService = todosService;
        }

        [HttpGet]
        [Route("getTodos")]
        public IHttpActionResult GetTodos ()
        {
            return Ok(_todoService.GetTodos());
        }

    }
    
}
using Acadamy.Core.BussinesModels;
using Acadamy.Core.RepositoryInterfaces;
using Acadamy.Core.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy.Core.Services
{
    public class TodosService : ITodosService
    {
        private readonly ITodosRepository _todosRepository;

        public TodosService (ITodosRepository todosRepository)
        {
            _todosRepository = todosRepository;
        }

        public IList<Todo> GetTodos()
        {
            return _todosRepository.GetAllTodos();
        }
    }
}

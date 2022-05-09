using Acadamy.Core.BussinesModels;
using Acadamy.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Infrastructure.Repositories
{
    public class LocalTodosRepository : ITodosRepository
    {
        public IList<Todo> GetAllTodos()
        {
            List<Todo> todos = new List<Todo>();

            todos.Add(new Todo() {
                CreationDate = new DateTime(),
                Title = "Limpieza",
                Description = "Limpiar la Cocina"
            });

            todos.Add(new Todo()
            {
                CreationDate = new DateTime(),
                Title = "Cocinar",
                Description = "Hacer comidas del día"
            });

            todos.Add(new Todo()
            {
                CreationDate = new DateTime(),
                Title = "Sacar la basura",
                Description = "Juntar y sacar la basura",
                DoneDate = new DateTime(2022, 5, 7)
            });

            return todos;

        }
    }
}

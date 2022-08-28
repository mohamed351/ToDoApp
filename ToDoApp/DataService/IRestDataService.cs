using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Model;

namespace ToDoApp.DataService
{
    public interface IRestDataService
    {
        Task<List<ToDo>> GetToDosAsync();
        Task AddToDoAsync(ToDo toDo);

        Task UpdateToDoAsync(ToDo toDo);

        Task DeleteAsync(int ID);


    }
}

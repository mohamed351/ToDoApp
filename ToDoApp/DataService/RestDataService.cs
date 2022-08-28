using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Model;

namespace ToDoApp.DataService
{
    public class RestDataService : IRestDataService
    {
        private readonly HttpClient httpClient;
        public RestDataService()
        {
            this.httpClient = new HttpClient();


        }
        public Task AddToDoAsync(ToDo toDo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<ToDo>> GetToDosAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateToDoAsync(ToDo toDo)
        {
            throw new NotImplementedException();
        }
    }
}

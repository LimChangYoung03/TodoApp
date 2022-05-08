using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepository
    {
        private static List<Todo> _todos = new List<Todo>();

        public TodoRepositoryInMemory()
        {
            _todos = new List<Todo>
            {
                new Todo { ID = 1, Titile = "ASP.Net Core 학습", IsDone = false},
                new Todo { ID = 2, Titile = "Blazor 학습", IsDone = false},
                new Todo { ID = 3, Titile = "C# 학습", IsDone = true}
            };
        }

        // 인 -메모리 데이터베이스 사용 영역
        public void Add(Todo model)
        {
            model.ID = _todos.Max(t => t.ID) + 1;
            _todos.Add(model);
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }
}


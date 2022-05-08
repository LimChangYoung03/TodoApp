using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace TodoApp.Models
{
    public class TodoRepositoryJson : ITodoRepository
    {
        private readonly string _filePath;
        private static List<Todo> _todos = new List<Todo>();
        
        public TodoRepositoryJson(string filepath = @"c:\TodoApp\Todos.json")
        {
            this._filePath = filepath;
            var todos = File.ReadAllText(filepath, Encoding.Default);
            _todos = JsonConvert.DeserializeObject<List<Todo>>(todos);

        }
        public void Add(Todo model)
        {
            model.ID = _todos.Max(t => t.ID) + 1;
            _todos.Add(model);
            //Json 파일 저장
            string json = JsonConvert.SerializeObject(_todos, Formatting.Indented);

            File.WriteAllText(_filePath, json);
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }
}


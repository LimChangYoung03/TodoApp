using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodoApp.Models
{
    public class TodoRepositoryFile : ITodoRepository
    {
        private readonly string _filePath;
        private static List<Todo> _todos = new List<Todo>();
        private Encoding encoding;

        //public TodoRepositoryFile()
        //{
        //    _todos = new List<Todo>
        //    {
        //        new Todo { ID = 1, Titile = "ASP.Net Core 학습", IsDone = false},
        //        new Todo { ID = 2, Titile = "Blazor 학습", IsDone = false},
        //        new Todo { ID = 3, Titile = "C# 학습", IsDone = true}
        //    };
        //}
        public TodoRepositoryFile(string filepath = @"c:\TodoApp\Todos.txt")
        {
            this._filePath = filepath;
            string[] todos = File.ReadAllLines(filepath,Encoding.Default);
            foreach(var t in todos)
            {
                string[] line = t.Split(',');
                _todos.Add(new Todo { ID = Convert.ToInt32(line[0]), Titile = line[1], IsDone = Convert.ToBoolean(line[2]) });
            }
           
        }

       
        // 인 -메모리 데이터베이스 사용 영역
        public void Add(Todo model)
        {
            model.ID = _todos.Max(t => t.ID) + 1;
            _todos.Add(model);

            string data = "";
            foreach(var t in _todos)
            {
                data += $"{t.ID},{t.Titile},{t.IsDone}{Environment.NewLine}";
            }
            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.Write(data);
                sw.Close();
                //sw.Dispose(); using 구문 사용시 안써도 된다
            }
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }
}


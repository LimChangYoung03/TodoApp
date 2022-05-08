using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITodoRepository _repository = new TodoRepository();
            List<Todo> todos = new List<Todo>();
            todos = _repository.GetAll();
            foreach (var t in todos)
            {
                Console.WriteLine($"{t.ID} - {t.Titile}({t.IsDone})");
            }
            Console.WriteLine();
            //[2]데이터 입력
            Todo todo = new Todo { Titile = "Database", IsDone = true };
            _repository.Add(todo);
            todos = _repository.GetAll();
            //[3]번 변경데이터 출력
            foreach (var t in todos)
            {
                Console.WriteLine($"{t.ID} - {t.Titile}({t.IsDone})");
            }
        }
    }
}

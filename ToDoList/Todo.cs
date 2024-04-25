using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Todo
    {
        public string NewTodo { get; set; }
        public List<Label> TodoList { get; set; } = new List<Label>();

        public void AddToDo(Label lbl)
        {
            TodoList.Add(lbl);
        }
    }
}

using System.Collections.Generic;

namespace TodoApp
{
    class TodoManager
    {
        List<TodoItem> listOfTodoItems = new List<TodoItem>();

        public void AddTodoItem(string title)
        {
            TodoItem newTodoItem = new TodoItem(title);
            newTodoItem.Title = title;
            listOfTodoItems.Add(newTodoItem);
        }

        public List<string> ListTodoItems() // 
        {
            List<string> returnList = new List<string>();
            foreach (TodoItem todo in listOfTodoItems)
            {
                returnList.Add(todo.ToString());
            }
            return returnList;
        }

        public void SetTodoItem(int index, bool isDone)
        {
            listOfTodoItems[index].IsDone = isDone;
        }

        public void RemoveTodoItem(int index)
        {
            listOfTodoItems.RemoveAt(index);
        }
    }
}
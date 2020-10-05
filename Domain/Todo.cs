using System;
using System.Collections.Generic;

namespace TodoApp
{
    class TodoItem
    {
        public string Title
        {
            get;
            set;
        }
        public bool IsDone
        {
            get;
            set;
        }
        public DateTime Deadline
        {
            get;
            set;
        } //Not yet used for anything
        public TodoItem(string title) //konstruktor har alltid samma namn som klassen
        {
            Title = title;
        }

        public override string ToString() //whyyy?
        {
            if (IsDone)
            {
                return Title + "| är klar";
            }
            else
            {
                return Title + "| inte klar";
            }
        }
    }
}
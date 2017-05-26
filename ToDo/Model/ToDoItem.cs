using System;
using SQLite;
using SQLite.Net.Attributes;

namespace ToDo
{
    public class ToDoItem
    {
        [SQLite.PrimaryKeyAttribute, SQLite.AutoIncrement]
        public int ID
        {
            get;
            set;
        }
        public string TaskName
        {
            get;
            set;
        }

        public string Priority
        {
            get;
            set;
        }

        public DateTime DueDate
        {
            get;
            set;
        }

        public bool IsDeleted
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using ToDo.ViewModel;
using Xamarin.Forms;

namespace ToDo
{
    public partial class CreatePage : ContentPage
    {
        public List<ToDoItem> toDoItems;
        public CreatePageViewModel vm;
        private int updateID = 0;

        public CreatePage(int id)
        {
            vm = new CreatePageViewModel();
            BindingContext = vm;
            toDoItems = new List<ToDoItem>();
            InitializeComponent();
            ToDoItem toDoItem = App.Database.GetToDo(id);
            ToDo.Text = toDoItem.TaskName;
            Priority.Text = toDoItem.Priority;
            Date.Date = toDoItem.DueDate;
            Time.Time = toDoItem.DueDate.TimeOfDay;
            updateID = id;
        }

        public CreatePage()
        {
            vm = new CreatePageViewModel();
            BindingContext = vm;
            InitializeComponent();
        }

        public void OnSave(object o, EventArgs e){
            vm.AddTask(
                ToDo.Text,
                Priority.Text,
                Date.Date,
                Time.Time.Hours,
                Time.Time.Minutes,
                Time.Time.Seconds,
                updateID,
                false
            );
            Clear();
        }


        private void Clear()
        {
            ToDo.Text = Priority.Text = String.Empty;
            Date.Date = DateTime.Now;
            Time.Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

		public void OnCancel(object o, EventArgs e)
		{
            Clear();
		}

		public void OnReview(object o, EventArgs e)
		{
            Clear();
            Navigation.PushAsync(new ListTasksPage());
		}
    }
}

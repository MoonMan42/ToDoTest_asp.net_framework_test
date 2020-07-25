using System;

namespace ToDoTest.ViewModel
{
    public class ToDoViewModel
    {
        public string ToDo { get; set; }
        public string DueDate { get; set; }



        public DateTime GetDueDate()
        {
            return DateTime.Parse(string.Format($"{DueDate}"));
        }
    }
}
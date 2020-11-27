using System;

namespace oscarlefttodo
{

    class Task
    {


        private string NameOfTask;
        private string Description;
        public bool Completed = false;

        public string Description1 { get => Description; set => Description = value; }
        public string NameOfTask1 { get => NameOfTask; set => NameOfTask = value; }

        public Task(string nameOfTask, string description)
        {
            NameOfTask = nameOfTask;
            Description = description;
        }
    }





    
}
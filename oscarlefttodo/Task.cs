using System;

namespace oscarlefttodo
{

    class Task
    {


        private string NameOfTask;
        private string Description;
        private bool completed = false;
        private bool archived = false;


        public string Description1 { get => Description; set => Description = value; }
        public string NameOfTask1 { get => NameOfTask; set => NameOfTask = value; }
        public bool Archived { get => archived; set => archived = value; }
        public bool Completed { get => completed; set => completed = value; }

        public Task(string nameOfTask, string description)
        {
            NameOfTask = nameOfTask;
            Description = description;
        }
    }





    
}
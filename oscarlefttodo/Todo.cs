using System;
using System.Collections.Generic;

namespace oscarlefttodo
{

    class Todo
    {


        public List<Task> taskList = new List<Task>();
        public void TodoMeny()
        {





            Console.WriteLine("Please choose one of these options");
            Console.WriteLine("Write one of these numbers that correspond to your option");

            int options = 0;
            do
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Choose what you want to do? Write the corresponding number too your choosen option");
                Console.WriteLine("***********");
                Console.WriteLine(" 1: List all tasks that you have created");
                Console.WriteLine("***********");
                Console.WriteLine(" 2: Create a new task");
                Console.WriteLine("***********");
                Console.WriteLine(" 3: Archive completed tasks");
                Console.WriteLine("***********");
                Console.WriteLine(" 4: List archived tasks");
                Console.WriteLine("***********");
                Console.WriteLine(" 0: Close the program");

                // This loop of exceptions handling was really good to find out about, makes the program so much smoother when it runs,
                // i used this for all exception handling in the code.
                bool loop = true;

                do
                {
                    try
                    {
                        options = Convert.ToInt32(Console.ReadLine());
                        loop = false;
                    }
                    catch
                    {
                        Console.WriteLine(" Error: You wrote in the wrong format, please rechoose your option again. ");
                    }
                }
                while (loop);
                // the switch cases are linked to the user input, and the diffrent cases calls diffrent metods to be executed
                switch (options)
                {
                    case 0:
                        Console.WriteLine("Simulation will be terminated!!");
                        break;
                    case 1:
                        ListAllTasks();
                        break;
                    case 2:
                        CreateNewTask();
                        break;
                    case 3:
                        ArchiveCompletedTasks();
                        break;
                    case 4:
                        ListAllArchivedTasks();
                        break;
                    default:
                        WrongOption();
                        break;
                }

            }
            while (options != 0);
        }

        public void WrongOption()
        {
            System.Console.WriteLine("You must choose a number that correspond to an option. please choose 0-4");
        }

        public void ListAllArchivedTasks()
        {
            throw new NotImplementedException();
        }

        public void ArchiveCompletedTasks()
        {
            throw new NotImplementedException();
        }

        public void CreateNewTask()
        {
            string taskName;
            string descriptionOfTask;

            System.Console.WriteLine("What name do you want to give your task? ");
            taskName = Console.ReadLine();
            System.Console.WriteLine("Write a short description of your task");
            descriptionOfTask = Console.ReadLine();

            taskList.Add(new Task(taskName,descriptionOfTask));


        }

        public void ListAllTasks()
        {

            

            foreach (var item in taskList)
            {

                System.Console.WriteLine(item.NameOfTask1);
                System.Console.WriteLine(item.Description1);
                System.Console.WriteLine(item.Description1);

            }

        }
    }








}







using System;
using System.Collections.Generic;
using System.Linq;

namespace oscarlefttodo
{

    class Todo
    {


        public List<Task> taskList = new List<Task>();
        public List<Task> archivedTaskList = new List<Task>();
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
                Console.WriteLine(" 3: Archive all your completed tasks");
                Console.WriteLine("***********");
                Console.WriteLine(" 4: List archived tasks");
                Console.WriteLine("***********");
                Console.WriteLine(" 0: Close the program");

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
            System.Console.WriteLine("Here is a list of all the task that you have move too the archive");
            System.Console.WriteLine();
            foreach (var item in archivedTaskList)
            {
                System.Console.WriteLine("Name of task: " + item.NameOfTask1);
                System.Console.WriteLine("Description of task: " + item.Description1);
                System.Console.WriteLine();
                
                
            }
        }

        public void ArchiveCompletedTasks()
        {

            int noCompletedTask = 0;

            foreach (var item in taskList)
            {

                if (item.Completed == true)
                {
                    item.Archived = true;
                    System.Console.WriteLine("You have archived this task: " + item.NameOfTask1);
                    archivedTaskList.Add(item);
                    noCompletedTask++;
                }
  
            }
            taskList.RemoveAll((x) => x.Archived == true);

            if (noCompletedTask == 0)
            {
                System.Console.WriteLine("You didnt have any completed task to archive, dont be lazy, do your task!");
            }

        }

        public void CreateNewTask()
        {
            string taskNameFromUser;
            string descriptionOfTaskFromUser;

            System.Console.WriteLine("What name do you want to give your task? ");
            taskNameFromUser = Console.ReadLine();
            System.Console.WriteLine("Write a short description of your task");
            descriptionOfTaskFromUser = Console.ReadLine();

            taskList.Add(new Task(taskNameFromUser, descriptionOfTaskFromUser));


        }

        public void ListAllTasks()
        {

            System.Console.WriteLine("You will now see a list of all the task that you have created ");
            System.Console.WriteLine("After that we will go through them one and one and you can change the task status if you want ");


            foreach (var item in taskList)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Name of task: " + item.NameOfTask1);

                System.Console.WriteLine("Description of task: " + item.Description1);

                if (item.Completed == false)
                {
                    System.Console.WriteLine("Task status: Task have NOT been completed  [x]");
                }
                else
                {
                    System.Console.WriteLine("Task status: Task have BEEN been completed  [✓]");
                }

            }

            System.Console.WriteLine("Press any key to if you are ready to proceed");
            Console.ReadKey();
            Console.Clear();

            foreach (var item in taskList)
            {

                System.Console.WriteLine("Name of task: " + item.NameOfTask1);
                if (item.Completed == false)
                {
                    System.Console.WriteLine("Task status: Task have NOT been completed  [x]");
                }
                else
                {
                    System.Console.WriteLine("Task status: Task have BEEN been completed  [✓]");
                }
                System.Console.WriteLine();
                System.Console.WriteLine("Do you want to change status? Write 1 or 2 depending on your option");
                Console.WriteLine(" 1: Yes! I want to change the status of the task");
                Console.WriteLine("***********");
                Console.WriteLine(" 2: No! I want to keep the status of the task");
                Console.WriteLine("***********");

                int options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {

                    case 1:
                        Console.Clear();
                        System.Console.WriteLine("You have changed the status of the task"); 
                        item.Completed = !item.Completed;
                        System.Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        System.Console.WriteLine("You didnt change the current status"); 
                        System.Console.WriteLine();
                        break;

                    default:
                        WrongOption();
                        break;
                }


            }

        }
    }








}







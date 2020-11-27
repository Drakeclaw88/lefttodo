using System;

namespace oscarlefttodo
{
    class Program
    {
        static void Main(string[] args)
        {

            var myTodo = new Todo();

            System.Console.WriteLine("Welcome to oscars todo app");
            System.Console.WriteLine("Here you can create task that you need to get done");
            System.Console.WriteLine("You can list all of the task that created");
            System.Console.WriteLine("You can mark the task as done and file them archive if you want");
            System.Console.WriteLine("You can also see a list of all your archived tasks ");
            System.Console.WriteLine("Easy and simple right?");
            System.Console.WriteLine("If You understand then press any key to continue");
            Console.ReadKey();

            myTodo.TodoMeny();
            




        }
    }
}

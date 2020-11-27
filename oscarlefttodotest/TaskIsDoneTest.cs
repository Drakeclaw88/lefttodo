using System;
using System.Collections.Generic;
using oscarlefttodo;
using Xunit;


namespace oscarlefttodotest
{
    public class TaskIsDoneTest
    {
        [Fact]
        public void Test1()
        {

            //arrange
             List<Task> testTaskList = new List<Task>();
            Task testTask = new Task("", "");

            //act
            
            testTaskList.Add(testTask);


            //assert

        }
    }
}

using System;
using System.Collections.Generic;
using oscarlefttodo;
using Xunit;


namespace oscarlefttodotest
{
    public class AddTaskInListTest
    {
        [Fact]
        public void Test1()
        {

            //arrange
            int emptyOrNot;
             List<Task> testTaskList = new List<Task>();
            Task testTask = new Task("", "");
            Task testTaskTwo = new Task("", "");

            //act
            
            testTaskList.Add(testTask);
            testTaskList.Add(testTaskTwo);
            emptyOrNot = testTaskList.Count;
            var expected = 2;
            var actual = emptyOrNot;


            //assert
            Assert.Equal(expected,actual);

        }
    }
}

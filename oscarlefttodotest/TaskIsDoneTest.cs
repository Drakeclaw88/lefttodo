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
            Task testTaskOne = new Task("", "");
            System.Console.WriteLine(testTaskOne.Completed);
            var expected = testTaskOne.Completed;


            //act
            testTaskOne.Completed = !testTaskOne.Completed;
            var actual = testTaskOne.Completed;
            


            //assert
            Assert.NotEqual(expected,actual);

        }
    }
}

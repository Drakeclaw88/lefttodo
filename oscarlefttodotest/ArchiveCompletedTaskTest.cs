using System;
using System.Collections.Generic;
using oscarlefttodo;
using Xunit;


namespace oscarlefttodotest
{
    public class ArchiveCompletedTaskTest
    {
        [Fact]
        public void Test1()
        {

            //arrange
            List<Task> notCompletedTask = new List<Task>();
            List<Task> completedAndArchivedList = new List<Task>();
            Task one = new Task("", "");
            Task two = new Task("", "");

            notCompletedTask.Add(one);
            notCompletedTask.Add(two);

            one.Completed = !one.Completed;
            two.Completed = !two.Completed;
            var startingValue = completedAndArchivedList.Count;





            //act
            
            foreach (var item in notCompletedTask)
            {
                if (item.Completed == true)
                {
                    item.Archived =true;
                    
                }
                
            }
            foreach (var item in notCompletedTask)
            {

                if (item.Archived == true)
                {
                    completedAndArchivedList.Add(item);
                }
                
            }
            var endingValue = completedAndArchivedList.Count;


            //assert
            Assert.NotEqual(startingValue,endingValue);

        }
    }
}

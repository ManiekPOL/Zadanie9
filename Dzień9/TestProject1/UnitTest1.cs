using Dzieñ9;
using System.ComponentModel;

namespace TestProject1
{
    public class Tests
    {
        

        [Test]
        public void TestStatistics()
            
           
        {
            var employee = new Employee("Adam", "Mork");
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(6, statistics.Max);
            Assert.AreEqual(3,3f, statistics.Average);
        }
    }
}
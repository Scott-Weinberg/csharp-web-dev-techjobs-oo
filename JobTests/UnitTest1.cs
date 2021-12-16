using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        Job test_job1;
        Job test_job2;
        Job test_job3;
        [TestInitialize]
        public void createJobObject() 
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            Job test_job3 = new Job("Ice cream tester", new Employer("Culvers"), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
        }
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            test_job1 = new Job();
            test_job2 = new Job();
            Console.WriteLine(test_job1.Id);
            Console.WriteLine(test_job2.Id);

            Assert.IsFalse(test_job1.Id != test_job2.Id);
        }
        [TestMethod]
        public void ConstructorSettingName()
        {
           
            Assert.IsTrue(test_job3.Name == "Ice cream tester");
        }

       

    }
}
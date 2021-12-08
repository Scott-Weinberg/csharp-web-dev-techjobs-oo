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
            Assert.IsTrue(test_job1.Id != test_job2.Id);

        }
        [TestMethod]
        public void TestJobConstructorSetsName()
        {

            Job test_job3 = new Job("Ice cream tester", new Employer("Culvers"), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.IsTrue(test_job3.Name.Equals("Ice cream tester"));

        }

        [TestMethod]
        public void TestJobConstructorSetsEmployerName()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.EmployerName.Equals("Acme"));
        }
        [TestMethod]
        public void TestJobConstructorSetsLocation()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.EmployerLocation.Equals("Desert"));
        }
        [TestMethod]
        public void TestJobConstructorSetsJobType()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.JobType.Equals("Quality control"));
        }
        [TestMethod]
        public void TestJobConstructorSetsCompetency()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(test_Job3.JobCoreCompetency.Equals("Persistence"));
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_Job3 = new Job("Product tesdter", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job test_Job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(test_Job3.Id, test_Job2.Id, 0.01);
        }


    }
}

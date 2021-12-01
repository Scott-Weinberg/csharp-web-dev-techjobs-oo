using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        Job test_Job1;
        Job test_Job2;
        Job test_Job3;
        [TestInitialize]
        public void CreateJob()
        {
            test_Job1 = new Job();
            test_Job2 = new Job();
           
        }
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            
            Assert.IsTrue(test_Job1.Id != test_Job2.Id);
               
        }
        [TestMethod]
        public void TestJobConstructorSetsName()
        {
            test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.Name == "Product tester");
        }
        [TestMethod]
        public void TestJobConstructorSetsEmployerName()
        {
            test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.EmployerName.ToString() == "Acme");
        }
        [TestMethod]
        public void TestJobConstructorSetsLocation()
        {
            test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.EmployerLocation.ToString() == "Desert");
        }
    }
}

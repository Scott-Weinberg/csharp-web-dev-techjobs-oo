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
        Job test_Job3;
        [TestInitialize]
        public void createJobObject() 
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
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

            Assert.IsTrue(test_job1.Id != test_job2.Id);
        }
        [TestMethod]
        public void ConstructorSettingName()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.Name.Equals("Product tester"));
        }

        [TestMethod]
        public void TestJobConstructorSetsEmployerName()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.EmployerName.Value.Equals("ACME"));
        }
        [TestMethod]
        public void TestJobConstructorSetsLocation()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.EmployerLocation.Value.Equals("Desert"));
        }
        [TestMethod]
        public void TestJobConstructorSetsJobType()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.JobType.Value.Equals("Quality control"));
        }
        [TestMethod]
        public void TestJobConstructorSetsCompetency()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_Job3.JobCoreCompetency.Value.Equals("Persistence"));
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job test_Job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(test_Job3.Equals(test_Job2));
        }
        [TestMethod]
        public void ToStringAddsBlankSpacesBeforeAndAfterName()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
                
            string actual= test_Job3.Name.ToString();
            string expected = "Product tester";
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void ToStringBlankLineBeforeEachFeild()
        {
            Job test_Job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string actual = test_Job3.ToString();

            string expected = "\nId: " + test_Job3.Id + "\n" +
                "\nName: " + test_Job3.Name + "\n" +
                "\nEmployer: " + test_Job3.EmployerName.Value + "\n" +
                "\nLocation: " + test_Job3.EmployerLocation.Value + "\n" +
                "\nPosition: " + test_Job3.JobType.Value + "\n" +
                "\nCore Competenecy: " + test_Job3.JobCoreCompetency.Value + "\n";

            Assert.AreEqual(actual, expected);

        

        }
        [TestMethod]
        public void IfPassedEmptyValueToStringSaysDataNotAvailable()
        {
            Job test_Job3 = new Job(null, new Employer(null), new Location(null), new PositionType(null), new CoreCompetency(null));
            string dataNotAvail = "Data not available";
            string actual = test_Job3.ToString();
            string expected =
                    "\nId: " + test_Job3.Id + "\n" +
                "\nName: " + dataNotAvail + "\n" +
                "\nEmployer: " + dataNotAvail + "\n" +
                "\nLocation: " + dataNotAvail + "\n" +
                "\nPosition: " + dataNotAvail + "\n" +
                "\nCore Competenecy: " + dataNotAvail + "\n";
            Assert.AreEqual(expected, actual);
        }
        
    }
}






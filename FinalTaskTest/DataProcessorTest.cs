using FinalTask;
using FinalTask.Data;
using FinalTask.Dto;
using System.Collections.Generic;

namespace FinalTaskTest
{
    [TestClass]
    public class DataProcessorTest
    {
        [TestMethod]
        public void GetSpezializationsTest()
        {
            //arrange
            bool expected = true;

            //act
            List<SpecializeDto> result = DataProcessor.GetSpezializations(CollegeList.GetCollegeList());

            //Assert
            Assert.AreEqual(expected, CompareData.CompareSpecializeDtoList(SpecializeDtoList.GetSpecializeDTOLists(), result));
        }

        [TestMethod]
        public void GetCollegeByMaxStudentsCountTest()
        {
            //arrange
            bool expected = true;

            //act
            College result = DataProcessor.GetCollegeByMaxStudentsCount(CollegeList.GetCollegeList());

            //Assert
            Assert.AreEqual(expected, CompareData.CompareCollegesWithMaxEmployees(CollegeList.GetCollegeList().Last(), result));
        }

        [TestMethod]
        public void GetEmployeesOrderBySalaryTest()
        {
            //arrange
            bool expected = true;
            //act
            College collegeWithMaxStudentCount =
                CollegeList.GetCollegeList().Aggregate((maxCount, curCount) => maxCount.Students.Count > curCount.Students.Count ? maxCount : curCount);

            List<Employee> result = DataProcessor.GetEmployeesOrderBySalary(collegeWithMaxStudentCount);

            //Assert
            Assert.AreEqual(expected, CompareData.CompareEmployeeList(EmployeeListFromCollegeWithMaxStudents.GetEmployees(), result));
        }
    }
}

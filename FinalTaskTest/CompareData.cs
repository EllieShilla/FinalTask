using FinalTask.Data;
using FinalTask;
using FinalTask.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskTest
{
    internal class CompareData
    {
        public static bool CompareSpecializeDtoList(List<SpecializeDto> expectedList, List<SpecializeDto> result)
        {
            if (expectedList.Count != result.Count) return false;

            int y = 0;
            for (int i = 0; i < expectedList.Count(); i++)
            {
                if (expectedList[i].Count != result[y].Count)
                    return false;
                if (!expectedList[i].Specialization.Equals(result[y].Specialization))
                    return false;
                if (!expectedList[i].Title.Equals(result[y].Title))
                    return false;

                y++;
            }
            return true;
        }

        public static bool CompareEmployeeList(List<Employee> firstList, List<Employee> secondList)
        {
            int y = 0;

            for (int i = 0; i < firstList.Count(); i++)
            {
                if (!firstList[i].FirstName.Equals(secondList[y].FirstName))
                    return false;
                if (!firstList[i].SecondName.Equals(secondList[y].SecondName))
                    return false;
                if (!firstList[i].ThirdName.Equals(secondList[y].ThirdName))
                    return false;
                if (!firstList[i].Position.Equals(secondList[y].Position))
                    return false;
                if (firstList[i].Salary != secondList[y].Salary)
                    return false;

                y++;
            }
            return true;
        }

        public static bool CompareCollegesWithMaxEmployees(College expectedCollege, College result)
        {
            if (expectedCollege.Employees.Count != result.Employees.Count || expectedCollege.Students.Count != result.Students.Count) return false;

            if (!expectedCollege.Title.Equals(result.Title)) return false;
            if (!expectedCollege.Address.Equals(result.Address)) return false;

            if (!CompareStudentList(expectedCollege.Students, result.Students)) return false;

            if (!CompareEmployeeList(expectedCollege.Employees, result.Employees)) return false;

            return true;
        }

        public static bool CompareStudentList(List<Student> firstList, List<Student> secondList)
        {
            int y = 0;

            for (int i = 0; i < firstList.Count(); i++)
            {
                if (!firstList[i].FirstName.Equals(secondList[y].FirstName))
                    return false;
                if (!firstList[i].SecondName.Equals(secondList[y].SecondName))
                    return false;
                if (!firstList[i].ThirdName.Equals(secondList[y].ThirdName))
                    return false;
                if (!firstList[i].Specialization.Equals(secondList[y].Specialization))
                    return false;
                if (!firstList[i].Group.Equals(secondList[y].Group))
                    return false;

                y++;
            }
            return true;
        }
    }
}

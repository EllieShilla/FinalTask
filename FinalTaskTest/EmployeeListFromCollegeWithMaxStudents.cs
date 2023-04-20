using FinalTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskTest
{
    internal class EmployeeListFromCollegeWithMaxStudents
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>() {
                new Employee() {
                  FirstName = "Андрій",
                    SecondName = "Клименко",
                    ThirdName = "Тарасович",
                    Position = "методист",
                    Salary = 6500
                },
                new Employee() {
                  FirstName = "Владислав",
                    SecondName = "Крамарчук",
                    ThirdName = "Генадієвич",
                    Position = "психолог",
                    Salary = 7900
                },
                new Employee() {
                  FirstName = "Костянтин",
                    SecondName = "Панасюк",
                    ThirdName = "Максимович",
                    Position = "вчитель",
                    Salary = 8300
                },
                new Employee() {
                  FirstName = "Ілля",
                    SecondName = "Іванович",
                    ThirdName = "Мирославович",
                    Position = "вчитель",
                    Salary = 9200
                }
            };
        }
    }
}

using FinalTask.Data;
using FinalTask;

internal class CollegeList
{
    public static List<College> GetCollegeList()
    {
        return new List<College> {
        new College() {
          Title = "Криворізький медичний коледж",
            Address = "вул. Медична, 14, м. Кривий Ріг, Дніпропетровська область, 50000",
            Employees = new List < Employee > () {
              new Employee() {
                  FirstName = "Артур",
                    SecondName = "Дмитренко",
                    ThirdName = "Всеволодович",
                    Position = "вчитель",
                    Salary = 7000
                },
                new Employee() {
                  FirstName = "Вікторія",
                    SecondName = "Півторак",
                    ThirdName = "Яківна",
                    Position = "психолог",
                    Salary = 8000
                },
                new Employee() {
                  FirstName = "Давид",
                    SecondName = "Савчук",
                    ThirdName = "Максимович",
                    Position = "вчитель",
                    Salary = 9500
                }
            },
            Students = new List < Student > () {
              new Student() {
                  FirstName = "Володимир",
                    SecondName = "Антоненко",
                    ThirdName = "Максимович",
                    Group = "група 1",
                    Specialization = "фельдшер"
                },
                new Student() {
                  FirstName = "Артур",
                    SecondName = "Дмитренко",
                    ThirdName = "Адамович",
                    Group = "група 2",
                    Specialization = "фельдшер на морських і річкових суднах"
                },
                new Student() {
                  FirstName = "Алла",
                    SecondName = "Луканюк",
                    ThirdName = "Віталіївна",
                    Group = "група 3",
                    Specialization = "акушерка"
                },
                new Student() {
                  FirstName = "Наталя",
                    SecondName = "Бородуліна",
                    ThirdName = "Володимирівна",
                    Group = "група 4",
                    Specialization = "медсестра"
                },
                new Student() {
                  FirstName = "Сергій",
                    SecondName = "Харченко",
                    ThirdName = "Генадієвич",
                    Group = "група 1",
                    Specialization = "фельдшер"
                }
            }
        },
        new College() {
          Title = "Київський коледж міського господарства Таврійського національного університету ім. В.І. Вернадського",
            Address = "Вулиця Джона Маккейна, 33, Київ",
            Employees = new List < Employee > () {
              new Employee() {
                  FirstName = "Любов",
                    SecondName = "Антоненко",
                    ThirdName = "Ростиславівна",
                    Position = "вчитель",
                    Salary = 8000
                },
                new Employee() {
                  FirstName = "Світлана",
                    SecondName = "Гаврильчук",
                    ThirdName = "Гаврилівна",
                    Position = "вчитель",
                    Salary = 7500
                }
            },
            Students = new List < Student > () {
              new Student() {
                  FirstName = "Анна",
                    SecondName = "Кудак",
                    ThirdName = "Олегівна",
                    Group = "група 1",
                    Specialization = "кібербезпека"
                },
                new Student() {
                  FirstName = "Тарас",
                    SecondName = "Василенко",
                    ThirdName = "Артурович",
                    Group = "група 1",
                    Specialization = "системний аналіз"
                },
                new Student() {
                  FirstName = "Тамара",
                    SecondName = "Черленюк",
                    ThirdName = "Юріївна",
                    Group = "група 2",
                    Specialization = "менеджмент"
                },
                new Student() {
                  FirstName = "Тимофій",
                    SecondName = "Харченко",
                    ThirdName = "Антонович",
                    Group = "група 2",
                    Specialization = "менеджмент"
                }
            }
        },
        new College() {
          Title = "Білгород-Дністровський професійний коледж природокористування, будівництва та комп'ютерних технологій",
            Address = "вул. Першотравнева, 53, м. Білгород-Дністровський, Одеська обл.",
            Employees = new List < Employee > () {
              new Employee() {
                  FirstName = "Костянтин",
                    SecondName = "Панасюк",
                    ThirdName = "Максимович",
                    Position = "вчитель",
                    Salary = 8300
                },
                new Employee() {
                  FirstName = "Владислав",
                    SecondName = "Крамарчук",
                    ThirdName = "Генадієвич",
                    Position = "психолог",
                    Salary = 7900
                },
                new Employee() {
                  FirstName = "Андрій",
                    SecondName = "Клименко",
                    ThirdName = "Тарасович",
                    Position = "методист",
                    Salary = 6500
                },
                new Employee() {
                  FirstName = "Ілля",
                    SecondName = "Іванович",
                    ThirdName = "Мирославович",
                    Position = "вчитель",
                    Salary = 9200
                }
            },
            Students = new List < Student > () {
              new Student() {
                  FirstName = "Поліна",
                    SecondName = "Маротчак",
                    ThirdName = "Володимирівна",
                    Group = "група 1",
                    Specialization = "оператор комп'ютерної техніки"
                },
                new Student() {
                  FirstName = "Григорій",
                    SecondName = "Пономаренко",
                    ThirdName = "Леонідович",
                    Group = "група 1",
                    Specialization = "оператор комп'ютерної техніки"
                },
                new Student() {
                  FirstName = "Мирослав",
                    SecondName = "Мельник",
                    ThirdName = "Павлович",
                    Group = "група 2",
                    Specialization = "каменяр"
                },
                new Student() {
                  FirstName = "Анатолій",
                    SecondName = "Павленко",
                    ThirdName = "Гаврилович",
                    Group = "група 3",
                    Specialization = "штукатур"
                },
                new Student() {
                  FirstName = "Євгеній",
                    SecondName = "Середа",
                    ThirdName = "Артемович",
                    Group = "група 1",
                    Specialization = "оператор комп'ютерної техніки"
                },
                new Student() {
                  FirstName = "Євгенія",
                    SecondName = "Панадій",
                    ThirdName = "Констянтинівна",
                    Group = "група 4",
                    Specialization = "майстер ландшафтного дизайну"
                },
                new Student() {
                  FirstName = "Геннадій",
                    SecondName = "Ткачук",
                    ThirdName = "Артемович",
                    Group = "група 2",
                    Specialization = "каменяр"
                }

            }
        }

      };
    }
}

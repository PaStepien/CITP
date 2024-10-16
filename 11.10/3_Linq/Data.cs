using System.Linq;

public class Data
{
  public static List<Course> GetCourses()
  {

    return new List<Course>
            {
                new Course{Id = 1, Name = "Database"},
                new Course{Id = 2, Name = "Programming"},
                new Course{Id = 3, Name = "Software Development"},
                new Course{Id = 4, Name = "AI"},
                new Course{Id = 5, Name = "Web Development"},

            };

  }

  public static List<Person> GetPersonData()
  {
    return new List<Person> {

            new Person {
                Name = "Brielle Kaufman",
                Email = "fusce.mollis@penatibuset.edu",
                Age = 29,
                CourseId = 1
            },
            new Person {
                Name = "Leroy Perez",
                Email = "est.nunc.laoreet@facilisisnon.org",
                Age = 30,
                CourseId = 4
            },
            new Person {
                Name = "Yetta Lindsey",
                Email = "pede@semperauctor.co.uk",
                Age = 25,
                CourseId = 1
            },
            new Person {
                Name = "Jennifer Watson",
                Email = "lacus.varius@porttitorinterdumsed.edu",
                Age = 21,
                CourseId = 3
            },
            new Person {
                Name = "Barbara Mitchell",
                Email = "volutpat.nulla@cursus.com",
                Age = 21,
                CourseId = 4
            },
            new Person {
                Name = "Caesar Stephens",
                Email = "enim.curabitur@massarutrum.edu",
                Age = 29,
                CourseId = 3
            },
            new Person {
                Name = "Olga West",
                Email = "adipiscing.non@vivamusnon.edu",
                Age = 21,
                CourseId = 5
            },
            new Person {
                Name = "Kirk Dennis",
                Email = "vel.turpis.aliquam@eutellus.co.uk",
                Age = 30,
                CourseId = 4
            },
            new Person {
                Name = "Shellie Ayala",
                Email = "adipiscing.fringilla@vitae.net",
                Age = 25,
                CourseId = 4
            },
            new Person {
                Name = "Adria Sandoval",
                Email = "dui.cum@nullafacilisised.net",
                Age = 25,
                CourseId = 3
            },
            new Person {
                Name = "Bo Ashley",
                Email = "integer.id@pretiumneque.net",
                Age = 29,
                CourseId = 5
            },
            new Person {
                Name = "Hilda Acosta",
                Email = "enim.suspendisse@pellentesque.edu",
                Age = 26,
                CourseId = 4
            },
            new Person {
                Name = "Christen Lester",
                Email = "rhoncus.nullam.velit@turpisnulla.edu",
                Age = 24,
                CourseId = 2
            },
            new Person {
                Name = "Bradley Frederick",
                Email = "tellus.sem@sagittisfelis.co.uk",
                Age = 28,
                CourseId = 1
            },
            new Person {
                Name = "Aimee Hansen",
                Email = "proin.vel@arcualiquamultrices.co.uk",
                Age = 29,
                CourseId = 3
            },
            new Person {
                Name = "Caldwell Clements",
                Email = "libero@nislarcu.org",
                Age = 27,
                CourseId = 3
            },
            new Person {
                Name = "Paul Burgess",
                Email = "sed.pede@necimperdietnec.net",
                Age = 21,
                CourseId = 1
            },
            new Person {
                Name = "MacKenzie Moreno",
                Email = "elit@lobortisquam.org",
                Age = 25,
                CourseId = 3
            },
            new Person {
                Name = "Thaddeus Roberson",
                Email = "molestie.arcu.sed@venenatislacus.org",
                Age = 21,
                CourseId = 4
            },
            new Person {
                Name = "Madeson Moore",
                Email = "sem@tempordiam.org",
                Age = 20,
                CourseId = 2
            }};
  }
}
using ConsoleApp16.classes;

namespace ConsoleApp16
{
    internal class Program
    {
        static Classroom[] classrooms = new Classroom[0];
        static int nextClassroomId = 1;
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Classroom yarat");
                Console.WriteLine("2. Student yarat");
                Console.WriteLine("3. Butun Telebeleri ekrana cixart");
                Console.WriteLine("5. Telebe sil");
                Console.WriteLine("6. Cixis");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreatClassroom();
                        break;
                    case "2":
                        CreatStudent();
                        break;
                    case "3":
                        ShowAllStudents();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Yanlis secim.");
                        break;
                }

            }
            static void CreatClassroom()
            {

                Console.WriteLine("Id daxil et");
                string id = Console.ReadLine();

                Console.WriteLine("Ad daxil et");
                string name = Console.ReadLine();

                Console.WriteLine("Back end yoxsa Front end");
            }


            static void ShowAllStudents()
            {
                Console.WriteLine("Butun telebeler:");

                foreach (var classroom in classrooms)
                {
                    foreach (var student in classroom.Students)
                    {
                        Console.WriteLine($"{classroom.Name} - {student.Id}. {student.Name} {student.surname}");
                    }
                }
            }

            static void CreatStudent()
            {
                if (classrooms.Length == 0)
                {
                    Console.WriteLine("Sinif yoxdur");
                    return;
                }
                Console.WriteLine("Telebe yarat");

                Console.WriteLine("Id daxil et");
                string id = Console.ReadLine();

                Console.WriteLine("Ad daxil et");
                string name = Console.ReadLine();

                Console.WriteLine("Surname daxil et");
                string surname = Console.ReadLine();

                Console.WriteLine("Sinif daxil et");
                string className = Console.ReadLine();

                if (classrooms == null)
                {
                    Console.WriteLine("Sinif tapilmadi");
                    return;
                }
            }

        }
    }
}

namespace Mini_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                do
                {
                    Console.WriteLine($"1.Classroom yarat:" +
                              $"\n2.Student yarat:" +
                              $"\n3.Butun telebeleri ekrana cixart:" +
                              $"\n4.Secilmis sinifdeki telebeleri ekrana cixart:" +
                              $"\n5.Telebe sil:");

                    Console.WriteLine($"Secim edin:");
                    string choice = Console.ReadLine();
                    switch ( choice )
                    {
                       
                         case "2":
                            string _idstr;
                            int _id;
                            do
                            {
                                Console.WriteLine($"student id daxil edin:");
                                _idstr = Console.ReadLine();
                            } while (!int.TryParse(_idstr, out _id));

                            Console.WriteLine($"student name daxil edin:");
                            string namee = Console.ReadLine();

                            Console.WriteLine($"student surname daxil edin:");
                            string surname= Console.ReadLine();
                            
                         break;
                         case "3":
                            Console.WriteLine("All students:");
                            foreach (var classroom in new Classroom[] { backendClassroom, frontendClassroom })
                            {
                                for (int i = 0; i < classroom.StudentCount; i++)
                                {
                                    var student = classroom.FindStudentById(i + 1);
                                    Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Classroom: {classroom.Name}");
                                }
                            }
                         break;
                         case "4":
                            Console.WriteLine("\nStudents in Backend class:");
                            for (int i = 0; i < backendClassroom.StudentCount; i++)
                            {
                                var student = backendClassroom.FindStudentById(i + 1);
                                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}");
                            }

                         break;
                         case "5":
                            backendClassroom.DeleteStudent(1);
                            Console.WriteLine("\nAfter deleting student with ID 1:");
                            for (int i = 0; i < backendClassroom.StudentCount; i++)
                            {
                                var student = backendClassroom.FindStudentById(i + 1);
                                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}");
                            }
                         break;
                    }
                    
                }
                while ( true );
                }
                
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
            }      
        }
    }
}

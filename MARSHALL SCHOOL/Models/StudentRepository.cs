
namespace MARSHALL_SCHOOL.Models
{
    public  class StudentRepository
    {
        static List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                FirstName = "Mufutau Morales",
                LastName = "Tatiana Willis",
                MobileNumber = "(726) 744-8824",
                FatherName = "Kessie Thornton",
                MotherName = "Freya Howell",
                Address = "880-2437 Ut Av.",
                Class = 3
            },
            new Student()
            {
                Id = 1,
                FirstName = "Mufutau Morales",
                LastName = "Tatiana Willis",
                MobileNumber = "(726) 744-8824",
                FatherName = "Kessie Thornton",
                MotherName = "Freya Howell",
                Address = "880-2437 Ut Av.",
                Class = 3
            },
            new Student()
            {
                Id = 2,
                FirstName = "Jaime Reyes",
                LastName = "April Graham",
                MobileNumber = "1-232-283-4507",
                FatherName = "Ulla Cannon",
                MotherName = "Slade Patton",
                Address = "P.O. Box 517, 6385 Quis, Rd.",
                Class = 7
            },
            new Student()
            {
                Id = 3,
                FirstName = "Buffy Harris",
                LastName = "Zeus Pugh",
                MobileNumber = "(931) 703-7428",
                FatherName = "Cameron Michael",
                MotherName = "Xander Parker",
                Address = "Ap #801-4882 Cursus St.",
                Class = 6
            },
            new Student()
            {
                Id = 4,
                FirstName = "Paloma Cohen",
                LastName = "Jaime Henderson",
                MobileNumber = "1-856-383-4424",
                FatherName = "Samuel O'brien",
                MotherName = "Akeem Stokes",
                Address = "118-5293 Quam, Rd.",
                Class = 3
            },
            new Student()
            {
                Id = 5,
                FirstName = "Troy Mercer",
                LastName = "Hunter Terrell",
                MobileNumber = "1-341-885-1236",
                FatherName = "Kelly Hinton",
                MotherName = "Whoopi Harris",
                Address = "Ap #283-8228 Curabitur Rd.",
                Class = 2
            }
        };

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student CreateStudent(Student student)
        {
            students.Add(student);
            return student;
        }

        public int RemoveStudent(int Id)
        {
            var std = students.FirstOrDefault(x => x.Id == Id);
            if (std == null)
            {
                return 0;
            }
            students.Remove(std);
            return 1;
        }



    }
}
    

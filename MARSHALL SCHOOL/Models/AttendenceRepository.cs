namespace MARSHALL_SCHOOL.Models
{
    public class AttendenceRepository
    {
        static List<Attendance> Attended = new List<Attendance>()
        {
            new Attendance()
            {
                AttendanceId = 1,
                StudentId=11,
                Date= new DateTime(13-11-2023),
                Attend=true
            },
             new Attendance()
            {
                AttendanceId = 2,
                StudentId=12,
                Date=new DateTime(12-12-2023),
                Attend=true
            },
              new Attendance()
            {
                AttendanceId = 1,
                StudentId=13,
                Date= new DateTime(03-01-2024),
                Attend=false
            },
               new Attendance()
            {
                AttendanceId = 1,
                StudentId=14,
                Date= new DateTime(09-01-2024),
                Attend=true
            },
                new Attendance()
            {
                AttendanceId = 1,
                StudentId=15,
                Date= new DateTime(05-01-2024),
                Attend=false
            },
        };
    }
}

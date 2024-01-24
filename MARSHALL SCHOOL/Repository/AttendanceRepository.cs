using Microsoft.AspNetCore.Mvc;

namespace MARSHALL_SCHOOL.Models
{
    public class AttendenceRepository
    {
        static List<Attendance> Attendances = new List<Attendance>()
        {
            new Attendance()
            {
                AttendanceId = 1,
                StudentId=1,
                Date=new DateTime(2024,01,24),
                Attend=true
            },
             new Attendance()
            {
                AttendanceId = 2,
                StudentId=1,
                Date= new DateTime(2024,01,24),
                Attend=false
            },
              new Attendance()
            {
                AttendanceId = 3,
                StudentId=2,
                Date= new DateTime(2024,01,02),
                Attend=false
            },
               new Attendance()
            {
                AttendanceId = 4,
                StudentId=2,
                Date= new DateTime(2024,01,15),
                Attend=true
            },
                new Attendance()
            {
                AttendanceId = 5,
                StudentId=3,
                Date= new DateTime(2024,01,13),
                Attend=false
            },
        };
        public List<Attendance> GetAtedenceByStdId(int stdId)

        {
            var stdAttendences = Attendances.Where(x => x.StudentId==stdId).ToList();
            return stdAttendences;

        }

        public List<Attendance> GetAllAttencessOrderByDate()
        {
            return Attendances.OrderBy(s=>s.Date).ToList();
        }

        public List<Attendance> GetAttedenceByIdAndDate(int id, string date)
        {
            var result = new List<Attendance>();
            var stdAtendeces = Attendances.Where(a => a.StudentId == id).ToList();
            if(stdAtendeces.Any())
            {
                result = stdAtendeces.Where(s => s.Date.ToString("yyyy-MM-dd") == date).ToList();
            }
            
            return result;
        }
    }
}

namespace MARSHALL_SCHOOL.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set;}
        public DateTime Date {  get; set;}
        public bool Attend { get; set;}

    }
}

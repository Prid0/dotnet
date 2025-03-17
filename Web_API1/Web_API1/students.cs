namespace Web_API1
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string DepartmentId { get; set; }
    }


    public enum Gender
    {
        Male,
        Female,
        Other
    }
}

namespace StudentPortal.Models.Entities
{
    public class StudentIdentity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Subscrebed { get; set; }

    }
}

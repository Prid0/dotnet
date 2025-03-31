using System.ComponentModel.DataAnnotations;

namespace WebApiCodeFirstDemo.Models
{
    public class UserModel
    {
        [Key]
        public int ID { get; set; }
        public string username { get; set; }
        public string userEmail { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
    }
}

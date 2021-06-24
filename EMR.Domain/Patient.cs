using Dapper;

namespace EMR.Domain
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public GenderEnum Gender { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }
        public string Diagnos { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }

    public enum GenderEnum
    {
        Male = 0,
        Female = 1,
    }
}

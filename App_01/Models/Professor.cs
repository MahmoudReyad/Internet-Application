using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Professor
    {
        [Required]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Department { set; get; }

        [Required]
        public string University { set; get; }

        [Required]
        public string UserId { set; get; }

        



    }
}

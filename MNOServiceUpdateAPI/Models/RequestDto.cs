using System.ComponentModel.DataAnnotations;

namespace MNOServiceUpdateAPI.Models
{
    public class RequestDto
    {
        [Required]
        public string accountnumber { get; set; }
        [Required]
        public string CIF { get; set; }
        [Required]
        public string phonenumber { get; set; }
    }
}

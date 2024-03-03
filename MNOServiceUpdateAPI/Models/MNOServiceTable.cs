using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNOServiceUpdateAPI.Models
{
    public class MNOServiceTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string accountnumber { get; set; }
        public string customerid { get; set; }
        public string phonenumber { get; set; }
        public string isexisting { get; set; }
        public DateTime datecreated { get; set; }

    }
}

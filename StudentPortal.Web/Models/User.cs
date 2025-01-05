using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Web.Models
{
    public class User
    {

        public int id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";
    }
}

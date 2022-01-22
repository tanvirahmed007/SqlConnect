using System.ComponentModel.DataAnnotations;

namespace SqlConnect.Models
{
    public class Studentclass1
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Roll { get; set; }
    }
}

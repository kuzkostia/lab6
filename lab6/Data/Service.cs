using System.ComponentModel.DataAnnotations;

namespace lab6.Data
{
    public class Service
    {
            [Key]
            public int ID { get; set; }
            [Required]
            public string ServiceName { get; set; } = null!;
            [Required]
            public string ServiceDescription { get; set; } = null!;
    }
}

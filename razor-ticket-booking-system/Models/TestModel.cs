using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace razor_ticket_booking_system.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

    }
}

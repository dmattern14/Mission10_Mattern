using System.ComponentModel.DataAnnotations;

namespace Mission10_Mattern.Data
{

    public class BowlingLeague
    {
        [Key] public int BowlerId { get; set; }
        [Required] public string BowlerName { get; set; }
        [Required] public string TeamName { get; set; }
        [Required] public string Address { get; set; }
        [Required] public string City { get; set; }
        [Required] public string State { get; set; }
        [Required] public string Zip { get; set; }
        [Required] public string PhoneNumber { get; set; }
    }
}
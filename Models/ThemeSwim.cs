using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Assignments_ThemeSwim.Models
{
    public class ThemeSwim
    {
        public int ID { get; set; }
        [StringLength(32, MinimumLength = 4)]
        [Display(Name = "Event Name")]
        [Required(ErrorMessage = "Event Name is required.")]
        public string EventName { get; set; }

        [Required(ErrorMessage = "Booking Date is required.")]
        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        [StringLength(32, MinimumLength = 4)]
        [Required(ErrorMessage = "Competition is required.")]
        public string Competition { get; set; }

        [StringLength(32, MinimumLength = 4)]
        [Display(Name = "Pool Name")]
        [Required(ErrorMessage = "Pool Name is required.")]
        public string PoolName { get; set; }

        [Required(ErrorMessage = "Entry Price is required.")]
        [Display(Name = "Entry Price")]
        public decimal EntryPrice { get; set; }

        [Range(1, 10)]
        [Required(ErrorMessage = "Number of Pool is required.")]
        public int NoOfPool { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "First letter must be uppercase & no special characters or numbers allowed")]
        [StringLength(32, MinimumLength = 4)]
        [Required(ErrorMessage = "Alotted Pool Name is required.")]
        public string AlottedPool { get; set; }
        
    }
}
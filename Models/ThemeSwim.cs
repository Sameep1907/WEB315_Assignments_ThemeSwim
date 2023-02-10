using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Assignments_ThemeSwim.Models
{
    public class ThemeSwim
    {
        public int ID { get; set; }
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        public string Competition { get; set; }
        public string PoolName { get; set; }
        public decimal EntryPrice { get; set; }

        /*public int Rating { get; set;}
        public string RelatedFilms {get; set;}*/
    }
}
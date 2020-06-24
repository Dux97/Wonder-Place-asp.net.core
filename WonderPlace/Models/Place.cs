using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WonderPlace.Models
{
    public class Place
    {
        public int ID { get; set; }

        // user ID from AspNetUser table.
        public string Userid { get; set; }

        public string Kraj { get; set; }
        public string Opis { get; set; }
        public string Miejsce { get; set; }
        public string Zdjecie { get; set; }
        public string Kontynent { get; set; }
        public PlaceStatus Status { get; set; }
    }

    public enum PlaceStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}

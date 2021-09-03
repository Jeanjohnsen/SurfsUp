using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurfsUp.Models
{
    public class Equipment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        public int Id
        {
            get { return id; }
            set { }
        }

        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        private Byte[] image;
        public Byte[] Image
        {
            get { return image; }
            set { image = value; }
        }

        private DateTime availableFrom;
        public DateTime AvailableFrom
        {
            get { return availableFrom; }
            set { availableFrom = value; }
        }

        private DateTime availableTo;
        public DateTime AvailableTo
        {
            get { return availableTo; }
            set { availableTo = value; }
        }

        private string location;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        private int renterId;
        public int RenterId
        {
            get { return renterId; }
            set { renterId = value; }
        }

        private ICollection<Reservation> reservations;
        public ICollection<Reservation> Reservations
        {
            get { return reservations; }
            set { reservations = value; }
        }
    }
}

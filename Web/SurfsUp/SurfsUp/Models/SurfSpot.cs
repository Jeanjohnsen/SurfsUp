using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace SurfsUp.Models
{
    public class SurfSpot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal longitude;
        public decimal Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        private decimal lattitude;
        public decimal Lattitude
        {
            get { return lattitude; }
            set { lattitude = value; }
        }
    }
}

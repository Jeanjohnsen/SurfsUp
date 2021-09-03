using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurfsUp.Models
{
    public class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int equipmentId;
        public int EquipmentId
        {
            get { return equipmentId; }
            set { equipmentId = value; }
        }

        private int reservedById;
        public int ReservedById
        {
            get { return reservedById; }
            set { reservedById = value; }
        }

        private DateTime reservedFrom;
        public DateTime ReservedFrom
        {
            get { return reservedFrom; }
            set { reservedFrom = value; }
        }

        private DateTime reservedTo;
        public DateTime ReservedTo
        {
            get { return reservedTo; }
            set { reservedTo = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace SurfsUp.Models
{
    public class Assessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int surfSpotId;
        public int SurfSpotId
        {
            get { return surfSpotId; }
            set { surfSpotId = value; }
        }

        private int rating;
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        private int crowdDensity;
        public int CrowdDensity
        {
            get { return crowdDensity; }
            set { crowdDensity = value; }
        }

        private string comment;
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        private Byte[] media;
        public Byte[] Media
        {
            get { return media; }
            set { media = value; }
        }
    }
}

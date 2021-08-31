using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurfsUp.Models
{
    public class SpotData
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

        private SurfSpot surfSpot;
        public SurfSpot SurfSpot
        {
            get { return surfSpot; }
            set { surfSpot = value; }
        }

        private DateTime timeOfData;
        public DateTime TimeOfData
        {
            get { return timeOfData; }
            set { timeOfData = value; }
        }

        private float waveHeight;
        public float WaveHeight
        {
            get { return waveHeight; }
            set { waveHeight = value; }
        }

        private float wavePeriod;
        public float WavePeriod
        {
            get { return wavePeriod; }
            set { wavePeriod = value; }
        }

        private float windSpeed;
        public float WindSpeed
        {
            get { return windSpeed; }
            set { windSpeed = value; }
        }

        private float waterTemp;
        public float WaterTemp
        {
            get { return waterTemp; }
            set { waterTemp = value; }
        }

        private Direction windDirection;
        public Direction WindDirection
        {
            get { return windDirection; }
            set { windDirection = value; }
        }

        private decimal tidalWater;
        public decimal TidalWater
        {
            get { return tidalWater; }
            set { tidalWater = value; }
        }
    }

    public enum Direction
    {
        North,
        South,
        East,
        West
    }
}



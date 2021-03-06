﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JourneyEntities
{
    public class Pitstop
    {
        public string id { get; set; }

        public int PitstopId { get; set; }

        public string PersonId { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }

        public DateTime PitstopDate { get; set; }

        public string PhotoLargeUrl { get; set; }

        public string PhotoMediumUrl { get; set; }

        public string PhotoSmallUrl { get; set; }

        public int TripId { get; set; }

        public string pitstopPosition { get; set; }

        public string Address { get; set; }
    }

    public class NewPitstop
    {       
        public string Title { get; set; }

        public string Note { get; set; }

        public DateTime PitstopDate { get; set; }

        public string pitstopPosition { get; set; }

        public string Address { get; set; }

        public IFormFile picture { get; set; }

        public int TripId { get; set; }

    }
}

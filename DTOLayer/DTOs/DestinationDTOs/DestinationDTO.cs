﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.DestinationDTOs
{
    public class DestinationDTO
    {
        public string CityName { get; set; }

        public string DayNight { get; set; }

        public double Price { get; set; }

        public string Image { get; set; }

        public string CoverImage { get; set; }

        public string Description { get; set; }

        public string Details1 { get; set; }

        public string Details2 { get; set; }

        public int Capacity { get; set; }

        public DateTime BlogDate { get; set; }

        public bool Status { get; set; }
    }
}

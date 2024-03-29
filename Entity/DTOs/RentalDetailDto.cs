﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int CustomerId { get; set; }
        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }


    }
}

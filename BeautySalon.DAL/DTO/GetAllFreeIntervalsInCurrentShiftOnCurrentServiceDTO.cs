﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.DAL.DTO
{
    public class GetAllFreeIntervalsInCurrentShiftOnCurrentServiceDTO
    {
        public ServicesDTO Services { get; set; }
        public  ShiftsDTO Shifts { get; set; }
        public  IntеrvalsDTO Interval {  get; set; }
      
    }
}

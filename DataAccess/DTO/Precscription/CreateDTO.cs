﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO.Precscription
{
    public class CreateDTO
    {
        public string AppointmentId { get; set; }
        public string Diagnose { get; set; }
        public string Reason { get; set; }
    }
}

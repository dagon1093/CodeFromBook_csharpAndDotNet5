﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    public class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointId { get; set; }
        public PointDescription()
        {
            PetName = "No-name";
            PointId = Guid.NewGuid();
        }
        
    }
}

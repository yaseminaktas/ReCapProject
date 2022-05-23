﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ColorDetailDto:IDto
    {
        public int ColorId { get; set; }
        public string Name { get; set; }
    }
}

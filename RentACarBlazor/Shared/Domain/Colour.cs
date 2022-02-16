﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarBlazor.Shared.Domain
{
    public class Colour : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}

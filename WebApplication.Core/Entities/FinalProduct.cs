﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Entities
{
    public class FinalProduct : BaseEntity<string>
    {
        public string GraphicProductId { get; set; }
        public virtual GraphicProduct GraphicProduct { get; set; }
    }
}

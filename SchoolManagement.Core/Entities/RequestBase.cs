﻿using SchoolManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities.Abstract
{
    public class RequestBase: IEntity
    {
        public DateTime SystemDate { get; set; }
        public DateTime UpdateSystemDate { get; set; }
    }
}

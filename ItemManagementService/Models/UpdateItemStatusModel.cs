﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItemManagementService.Models
{
    public class UpdateItemStatusModel
    {
        public int Id { get; set; }
        public string StatusCd { get; set; }
    }
}
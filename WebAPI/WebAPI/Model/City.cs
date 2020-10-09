﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
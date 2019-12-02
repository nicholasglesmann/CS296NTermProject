﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class MoodTag : ITag
    {
        [Key]
        public int MoodTagID { get; set; }

        public MoodTag(string mood)
        {
            Tag = mood;
        }

        public string Tag { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class Driver
    {
        public string Name { get; set; }
        public string Skill {  get; set; }

        public Driver(string name, string skill) 
        { 
            Name = name; 
            Skill = skill; 
        }
    }
}

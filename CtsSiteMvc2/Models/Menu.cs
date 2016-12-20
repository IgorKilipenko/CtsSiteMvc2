﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CtsSiteMvc2.Models
{
    public class Menu
    {
        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<MenuItem> MenuItems { get; set; } 
    }
}
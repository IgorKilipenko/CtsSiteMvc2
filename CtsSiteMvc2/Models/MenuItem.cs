using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CtsSiteMvc2.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string Url { get; set; }
        public Menu ParentMenu { get; set; } = null;
        public bool Disable { get; set; } = false;
        public bool HasAccess { get; set; } = true;
        public bool IsSelected { get; set; } = false;

    }
}
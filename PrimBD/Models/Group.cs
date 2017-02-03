using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimBD.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Curator { get; set; }
        public List<Student> Students { get; set; }
    }
}
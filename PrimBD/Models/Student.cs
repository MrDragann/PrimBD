using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimBD.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IdGroup { get; set; }
        public List<Group> Groups { get; set; }
    }
}
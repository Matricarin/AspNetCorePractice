using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroLesson.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FactoryId { get; set; }
    }
}
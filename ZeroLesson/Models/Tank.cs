using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroLesson.Models
{
    public class Tank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Volume{ get; set; }
        public int MaxVolume{ get; set; }
        public int UnitId { get; set; }
    }
}
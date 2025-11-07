using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F25Week9CodeFirstApproach
{
    public class Standard
    {
        // scalar properties
        public int StandardId { get; set; }
        public string? StandardName { get; set; }

        // navigation property
        public ICollection<Student>? Students { get; set; }
    }
}

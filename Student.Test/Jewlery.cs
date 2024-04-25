using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewlery.Test
{
    public class JewleryEntityBase
    {
        public string Type { get; set; }
        public string StoneName { get; set; }

        public DateTime Collection { get; set; }
        public char Material { get; set; }
    }
}

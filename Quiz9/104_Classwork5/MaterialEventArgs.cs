using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz7;

namespace _106_Classwork8
{
    public class MaterialEventArgs: EventArgs
    {
        public string MaterialName { get; set; }
        public ShapeType.Material MaterialType { get; set; }
    }
}

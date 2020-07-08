using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz7;

namespace _106_Quiz9
{
    public class SetMaterialEventArgs : EventArgs
    {
        private string _mType;
        public ShapeType.Material MType {set;get;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace space.Rotation
{
    public interface IRotation
    {
        Angle angle { get; set; }
        Angle angspeed { get; set; }
    }
}

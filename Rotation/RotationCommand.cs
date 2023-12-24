using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace space.Rotation
{
    internal class RotationCommand:ICommand
    {
        private readonly Angle _angle;
        public RotationCommand() { }
    }
}

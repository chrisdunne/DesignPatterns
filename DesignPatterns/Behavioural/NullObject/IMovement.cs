using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.NullObject
{
    public interface IMovement
    {
        void Jump();
        void Crouch();
        void Forwards();
        void Backwards();
    }
}

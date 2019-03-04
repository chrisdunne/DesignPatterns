using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.NullObject
{
    public class NoMovement : IMovement
    {
        public void Backwards() { }

        public void Crouch() { }

        public void Forwards() { }

        public void Jump() { }
    }
}

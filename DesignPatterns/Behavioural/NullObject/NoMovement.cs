using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.NullObject
{
    public class NoMovement : IMovement
    {
        private int _x;
        private int _y;

        public void Backwards() { }

        public void Down() { }

        public void Forwards() { }

        public void Up() { }
    }
}

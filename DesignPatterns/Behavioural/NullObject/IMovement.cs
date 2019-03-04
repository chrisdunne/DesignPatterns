using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.NullObject
{
    public interface IMovement
    {
        void Forwards();
        void Backwards();
        void Up();
        void Down();
    }
}

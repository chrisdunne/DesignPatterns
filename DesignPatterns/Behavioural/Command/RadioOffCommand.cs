using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Command
{
    public class RadioOffCommand : ICommand
    {
        private RadioReceiver _receiver;

        public RadioOffCommand(RadioReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Off();
        }

        public void Undo()
        {
            _receiver.On();
        }
    }
}

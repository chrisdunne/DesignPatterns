using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Command
{
    public class RadioOnCommand : ICommand
    {
        private RadioReceiver _receiver;

        public RadioOnCommand(RadioReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.On();
        }

        public void Undo()
        {
            _receiver.Off();
        }
    }
}

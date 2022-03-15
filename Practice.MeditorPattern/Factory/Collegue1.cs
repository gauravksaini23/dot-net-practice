using Practice.MeditorPattern.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MeditorPattern.Factory
{
    public class Collegue1 : ICollegue
    {
        readonly IMediator _mediator;
        public Collegue1(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Collegue1 got message {message}");
        }
    }
}

using Practice.MeditorPattern.Provider;

namespace Practice.MeditorPattern.Factory
{
    public class Collegue2 : ICollegue
    {
        readonly IMediator _mediator;
        public Collegue2(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Collegue2 got message {message}");
        }
    }
}
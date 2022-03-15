using Practice.MediatorPattern.MultipleParticipants.Provider;

namespace Practice.MediatorPattern.MultipleParticipants.Factory
{
    public class ChatRoom : IChatRoom
    {
        Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();
        public void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants.Add(participant.Name, participant);
            }
            participant.ChatRoom = this;
        }

        public void Send(string from, string to, string message)
        {
            var participant = _participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}

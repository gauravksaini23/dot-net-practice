// See https://aka.ms/new-console-template for more information
using Practice.MediatorPattern.MultipleParticipants.Factory;

var chatroom = new ChatRoom();

var john = new Participant("John");
var brian = new Participant("Brian");
var catherine = new Participant("Catherine");
var katy = new Participant("Katy");
var fraser = new Participant("Fraser");

chatroom.Register(john);
chatroom.Register(brian);
chatroom.Register(catherine);
chatroom.Register(katy);
chatroom.Register(fraser);

fraser.Send("Katy","Hi Katy, Please raise a change request to deploye Corp-Ace to production");
katy.Send("Fraser", "Hi Fraser, Sure !!!");
fraser.Send("Catherine","Hi Catherine, We are carrying out Corp-Ace deployement to prduction.");
catherine.Send("Fraser", "Sure Fraser, I will inform my team.");
katy.Send("Brian","Hi Brian, Can someone from your team pick the request ?");
brian.Send("John", "Hi John, Please pick the request and do the needful");
john.Send("Fraser","Hi Fraser, Deployment is done !!!");

Console.ReadKey();



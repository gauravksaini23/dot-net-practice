using Practice.MeditorPattern.Factory;

var mediator = new Mediator();
var collegue1 = new Collegue1(mediator);
var collegue2 = new Collegue2(mediator);

mediator.collegue1 = collegue1;
mediator.collegue2 = collegue2;

collegue1.Send("Hello, How are you ?");
collegue2.Send("I am fine. Thank You");

Console.ReadKey();
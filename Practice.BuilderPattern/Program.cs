// See https://aka.ms/new-console-template for more information
using Practice.BuilderPattern.Factory;

var motorCycle = new MotorCycleBuilder();
var shop = new Shop();
shop.Construct(motorCycle);
motorCycle.Vehicle.Show();



using Practice.CompositPattern.Factory;

var root = new Composite("root");
root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));

var subRoot = new Composite("CompositX");
subRoot.Add(new Leaf("Leaf XA"));
subRoot.Add(new Leaf("Leaf XBB"));
root.Add(subRoot);

root.Display(1);
Console.ReadKey();
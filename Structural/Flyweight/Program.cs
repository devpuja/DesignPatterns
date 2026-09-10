using Flyweight;

var factory = new TreeTypeFactory();
var oakType = factory.GetTreeType("Oak", "Green");
var oakType2 = factory.GetTreeType("Oak", "Red");
var pineType = factory.GetTreeType("Pine", "Dark Green");
var cocoType = factory.GetTreeType("Coco", "Brown");

var tree1 = new Tree(10, 20, oakType);
var tree2 = new Tree(30, 40, oakType2);
var tree3 = new Tree(50, 60, pineType);
var tree4 = new Tree(70, 80, pineType);
var tree5 = new Tree(90, 100, cocoType);


tree1.Display();
tree2.Display();
tree3.Display();
tree4.Display();
tree5.Display();

Console.WriteLine(ReferenceEquals(oakType, oakType2));
Console.WriteLine(ReferenceEquals(oakType, pineType));
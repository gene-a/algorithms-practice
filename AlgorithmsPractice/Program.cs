// See https://aka.ms/new-console-template for more information
using AlgorithmsPractice.UnionAndFind;

Console.WriteLine("Quick Find!");

var qF = new QuickFind(9);
qF.Union(4, 3);
qF.Union(3, 8);
qF.Union(6, 5);
qF.Union(9, 4);
qF.Union(2, 1);

qF.Connected(8, 9);
qF.Connected(5, 0);
qF.Connected(5, 0);

qF.Union(7, 2);
qF.Union(6, 1);

Console.WriteLine("Quick Union!");
var qU = new QuickUnion(9);
qU.Union(4, 3);
qU.Union(3, 8);
qU.Union(6, 5);
qU.Union(9, 4);
qU.Union(2, 1);

qU.Connected(8, 9);
qU.Connected(5, 4);

qU.Union(5, 0);
qU.Union(7, 2);
qU.Union(6, 1);
qU.Union(7, 3);
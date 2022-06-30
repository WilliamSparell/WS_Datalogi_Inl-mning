﻿using WS_Datalogi_Inlämning;

BinarySearchTree<int> BST = new BinarySearchTree<int>();

const int size = 10;

Random rnd = new();
for (int i = 0; i < size; i++)
{
    BST.Insert(1);
    //BST.Insert(rnd.Next(1, 100));
}
Console.WriteLine("10 " + BST.Count());
Console.WriteLine("false " + BST.Exists(420));
Console.WriteLine("true " + BST.Exists(7));

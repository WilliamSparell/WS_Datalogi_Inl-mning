using WS_Datalogi_Inlämning;

BinarySearchTree<int> BST = new BinarySearchTree<int>();

const int size = 20;

for (int i = 0; i < size; i++)
{
    BST.Insert(i);
}
Console.WriteLine("20 " + BST.Count());
Console.WriteLine("false " + BST.Exists(420));
Console.WriteLine("true " + BST.Exists(7));

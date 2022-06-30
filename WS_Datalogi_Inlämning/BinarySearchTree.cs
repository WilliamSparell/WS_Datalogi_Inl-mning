namespace WS_Datalogi_Inlämning
{
    public class BinarySearchTree<T> : IBST_G<T> where T : IComparable<T>
    {
        private int Counter = 0;
        private Node<T>? Root = null;

        public void Insert(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Root == null)
            {
                Root = newNode;
                Counter++;
            }
            else
            {
                var Current = Root;
                while (true)
                {
                    if (value.CompareTo(Current.Data) < 0)
                    {
                        if (Current.LeftChild == null)
                        {
                            Current.LeftChild = newNode;
                            Counter++;
                            break;
                        }
                        else
                        {
                            Current = Current.LeftChild;
                        }
                    }
                    else if (value.CompareTo(Current.Data) > 0)
                    {
                        if (Current.RightChild == null)
                        {
                            Current.RightChild = newNode;
                            Counter++;
                            break;
                        }
                        else
                        {
                            Current = Current.RightChild;
                        }
                    }
                    else // Tillåter inte likadana värden
                    {
                        break;
                    }
                }
            }
        }
        public bool Exists(T value)
        {
            var Current = Root;
            if (Current == null)
                return false;

            while (Current != null)
            {
                if (value.CompareTo(Current.Data) == 0)
                    return true;
                else if (value.CompareTo(Current.Data) < 0)
                    Current = Current.LeftChild;
                else 
                    Current = Current.RightChild;
            }
            return false;
        }
        public int Count()
        {
            return Counter;
        }
    }
}

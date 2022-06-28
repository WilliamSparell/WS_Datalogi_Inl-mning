using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_Datalogi_Inlämning
{
    public class BinarySearchTree<T> : IBST_G<T> where T : IComparable<T>
    {
        private int Counter = 0;
        private Node<T>? Root = null;
        private Node<T>? Current = null;

        public int Count()
        {
            return Counter;
        }

        public bool Exists(T value)
        {
            throw new NotImplementedException();
        }

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
                Current = Root;
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
                    else
                    {
                        if (Current.RightChild == null)
                        {
                            Current.RightChild = newNode;
                            Counter++;
                            break;
                        }
                        else if (Current.LeftChild == null)
                        {
                            Current.LeftChild = newNode;
                            Counter++;
                            break;
                        }
                        else
                        {
                            Current = Current.RightChild;
                        }
                    }
                }
            }
        }
        //public int CompareTo()
        //{
        //    if (other = null) return -1;
        //    if (id < other.id) return -1;
        //    else if (id > other.id) return 1;
        //    else return 0;

        //}
    }
}

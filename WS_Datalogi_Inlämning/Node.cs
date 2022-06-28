using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_Datalogi_Inlämning
{
    internal class Node<T>
    {
		public T Data { get; set; }
		public Node<T>? LeftChild { get; set; }
		public Node<T>? RightChild { get; set; }

		public Node(T value)
		{
			LeftChild = null;
			RightChild = null;
			Data = value;
		}

		public int GetBalance()
		{
			int left = (LeftChild == null) ? 0 : LeftChild.GetBalance() + 1;
			int right = (RightChild == null) ? 0 : RightChild.GetBalance() + 1;
			return Math.Abs(right - left);
		}
	}
}

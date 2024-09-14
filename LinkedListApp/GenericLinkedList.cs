using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListApp
{
    public class GenericLinkedList<T>
    {
        public Node<T>? _head { get; set; }

        public GenericLinkedList(T data)
        {
            Insert(data);
        }

        public void InsertAt(int position, T data)
        {
            if (_head != null)
            {
                Node<T> node = _head;
                for (int i = 0; i < position - 1; i++)
                {
                    if (node == null)
                    {
                        throw new IndexOutOfRangeException("Position Not Found. Please make sure you insert on the position that exists.");
                    }
                    node = node.Next;
                }

                Console.WriteLine($"Inserting {data} at position { position }.");
                Node<T> currentNode = node;
                Node<T> nextNode = node.Next;
                Node<T> newNode = new Node<T>(data);
                currentNode.Next = newNode;
                newNode.Next = nextNode;
            }
            
        }

        public void Insert(T data)
        {
            var newNode = new Node<T>(data);
            if (_head == null)
                _head = newNode;
            else
            {
                var current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void RemoveAt(int position)
        {
            if (_head == null)
            {
                return;
            }

            Console.WriteLine($"Removing at position {position}");

            Node<T> node = _head;

            if (position == 0)
            {
                _head = node.Next;
                return;
            }
            for (int i = 0; node != null && i < position - 1; i++)
            {
                node = node.Next;
            }
            if (node == null || node.Next == null)
            {
                return;
            }

            // Node node->next is the node to be deleted
            Node<T> nextNode = node.Next.Next;
            node.Next = nextNode;
        }

        public void PrintAll()
        {
            Node<T> node = _head;
            while (node != null) 
            {
                Console.WriteLine(node.Data);
                node = node.Next; 
            }
            Console.WriteLine();
        }

    }

}

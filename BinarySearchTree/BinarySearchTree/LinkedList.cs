using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class LinkedList
    {
        private Node head;
        

        public void printAllNodes()
        {
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }

        public void AddFirst(int data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(int data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            } 
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = toAdd;



            }
        }









    }
}

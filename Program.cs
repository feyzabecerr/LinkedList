using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        class LinkedListNode
        {
            public int data;
            public LinkedListNode next;
            private LinkedListNode head;

            public LinkedListNode(int x)
            {
                this.data = x;
                this.next = null;
            }

            public LinkedListNode(LinkedListNode head)
            {
                this.head = head;
            }
        }

        class Linked_List
        {
            int count;
            LinkedListNode head;

            public Linked_List()
            {
                head = null;
                count = 0;
            }

            public void AddNodeFront(int data)
            {
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;
                head = node;
                count++;
            }

            public void AddNodeTail(int data)
            {
                LinkedListNode node = new LinkedListNode(data);
                if(head == null)
                {
                    head = node;
                }
                else
                {
                    var currentNode = head;
                    while(currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }
                    currentNode.next = node;
                }
            }

            public void AddNodeAtPosition(int data,int position)
            {
                LinkedListNode node = new LinkedListNode(data);

                node.next = null;

                if(position == 1)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    var temp = head;
                    for(int i=0; i<position-1; i++)
                    {
                        temp = temp.next;
                    }
                    node.next = temp.next;
                    temp.next = node;
                }
               
       
            }

            public void DeleteNodeAtPosition(int position)
            {
                LinkedListNode temp = head;
                LinkedListNode node;
                if(position == 0)
                {
                    head = temp.next;
                    return;
                }

                if(temp== null || temp.next == null)
                {
                    return;
                }
               
                for (int i = 0; i < position - 1; i++)
                {
                    temp = temp.next;

                }
                node = temp.next.next;
                temp.next = node;
               
            }

            public void reverseList()
            {
                LinkedListNode node = head;
                LinkedListNode prev = null;
                LinkedListNode next = null;
                
                while (node != null)
                {
                    next = node.next;
                    node.next = prev;
                    prev = node;
                    node = next;
                  
                }
                head = prev;
                Console.WriteLine("Reversed List:");
                PrintList();
                
            }

          
            public void PrintList()
            {
                LinkedListNode runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }

            }

        }

        static void Main(string[] args)
        {
            Linked_List linkedList = new Linked_List();
            Console.WriteLine("Linked List:");
            linkedList.AddNodeFront(5);
            linkedList.AddNodeFront(7);   
            linkedList.AddNodeFront(14);
            linkedList.AddNodeTail(49);
            linkedList.AddNodeFront(10);
            linkedList.AddNodeAtPosition(23, 5);
            linkedList.AddNodeAtPosition(74, 3);
            linkedList.DeleteNodeAtPosition(5);
            linkedList.PrintList();
            linkedList.reverseList();
            Console.ReadLine();

        }

    }
}
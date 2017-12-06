using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleList
{
    class ListClass<T>
    {
        //List<T> anyList = new List<T>();
        public class Node
        {
            public T info;
            public Node next;

        }
        private int size;
        public int count
        {
            get
            {
                return size;
            }
        }
        private Node head;
        private Node current;
        public ListClass()
        {
            size = 0;
            head = null;
        }

        public void Add(T content)
        {
            size++;
            var node = new Node()
            {
                info = content
            };
            if (head == null)
            {
                head = node;
            }
            else
            {
                current.next = node;
            }
            current = node;
        }
        public void ListNodes()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.info);
                temp = temp.next;
            }
        }
        public T  Retrieve(int Position)
        {
            Node tempNode = head;
            Node retNode = null;
            int count = 0;

            while (tempNode != null)
            {
                if (count == Position - 1)
                {
                    retNode = tempNode;
                    break;
                }
                count++;
                tempNode = tempNode.next;
            }

            return retNode.info;
        }
        public bool Delete(int Position)
        {
            if (Position == 1)
            {
                head = null;
                current = null;
                return true;
            }

            if (Position > 1 && Position <= size)
            {
                Node tempNode = head;

                Node lastNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == Position - 1)
                    {
                        lastNode.next = tempNode.next;
                        return true;
                    }
                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.next;
                }
            }

            return false;
        }



    }

    class Program
    {

        public static void Main(string[] args)
        {
            ListClass<object> lexample = new ListClass<object>();

            while (true)
            {
                Console.WriteLine("1.List elements");
                Console.WriteLine("2.Add element");
                Console.WriteLine("3.Search element(given position)");
                Console.WriteLine("4.Delete element(given position) ");
                Console.WriteLine("5.Exit");

                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            lexample.ListNodes();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the element to be added to the list : ");
                            object temp = Console.ReadLine();
                            lexample.Add(temp);
                            break;

                        }
                    case 3:
                        {
                        Console.WriteLine("Enter the position of the element to search:");
                        int position = int.Parse(Console.ReadLine());
                        object result = lexample.Retrieve(position);

                            if (result != null)
                            {
                                Console.WriteLine("Element at Position " + position + " is " + result);
                            }
                            else
                            {
                                Console.WriteLine("Entered element id is Invalid");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the position of the element to be deleted:");
                            int position = int.Parse(Console.ReadLine());
                            object result = lexample.Retrieve(position);
                            if(lexample.Delete(position))
                            {
                                Console.WriteLine("Element " + result + " has been deleted!");
                            }
                            else
                            {
                                Console.WriteLine("Entered element id is Invalid");
                            }
                         

                            break;
                         }
                    case 5:
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You have Entered wrong choice ");
                            break;
                        }


                }

            }

        }
    }
}

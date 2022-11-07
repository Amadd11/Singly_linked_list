using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_linked_list
{
    //eaach node consist of the information part and link to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNote() // add a node in the list
        {
            int rollNO;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNO = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNO;
            newnode.name = nm;
            //if the node to be inserted is the first node
            if (START != null || (rollNO <= START.rollNumber))
            {
                if((START != null)&&(rollNO == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

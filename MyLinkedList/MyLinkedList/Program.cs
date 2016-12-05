/*
 * Created by SharpDevelop.
 * User: skorir002
 * Date: 9/30/2016
 * Time: 9:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MyLinkedList
{
	public class Node{
		public Node next;
		public object data;
		
	}
	public class LinkedList{
		private Node head;
		
		public void printAllNodes(){
			Node current=head;
			while(current!=null){
				Console.WriteLine(current.data);
				current=current.next;
			}
		}
		public void addFirst(Object data){
			Node toAdd= new Node();
			toAdd.data=data;
			toAdd.next=head;
			head= toAdd;
			
		}
		public void AddLast(Object data)
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
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Add First:");
			LinkedList myList= new LinkedList();
			myList.addFirst("Hello");
			myList.addFirst("Magical");
            myList.addFirst("World");
			myList.printAllNodes();
			Console.WriteLine();
	            Console.WriteLine("Add Last:");
	        LinkedList myList2 = new LinkedList();
	
	        myList.AddLast("Hello");
	        myList.AddLast("Magical");
	        myList.AddLast("World");
	        myList.printAllNodes();
	
	        Console.ReadLine();
		}
	}
}
//Insertion at end in a linked List
using System;
class HelloWorld {
  static void Main()
  {
    LinkedList lld = new LinkedList();
    Node head = new Node(5);
    Node currNode = lld.Insert(10,head);
    currNode = lld.Insert(15,currNode);
    currNode = lld.Insert(20,currNode);
    lld.TraverseLinkedList(head);
    
  }
  
}
public class Node
{
    public int data;
    public Node next;
    
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

public class LinkedList
{
    public Node Insert(int data, Node prevNode)
    {
        Node newNode = new Node(data);
        prevNode.next = newNode;
        return newNode;
    }
    
    public void TraverseLinkedList(Node head)
    {
        Node curr = head;
        while(curr != null)
        {
            Console.Write(curr.data);
            if(curr.next != null)
            {
                Console.Write(" -> ");
            }
            curr = curr.next;
        }
    }
}
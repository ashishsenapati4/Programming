//Insertion at beginning in a linked List
using System;
class HelloWorld {
  static void Main()
  {
    LinkedList lld = new LinkedList();
    Node head = new Node(5);
    head = lld.Insert(15,head);
    head = lld.Insert(20,head);
    head = lld.Insert(30,head);
    
    head = lld.Delete(head);
    // head = lld.Delete(head);
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
    public Node Insert(int data,Node head)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        return newNode;
    }
    
    public Node Delete(Node head)
    { 
        if(head == null)
        {
            return null;
        }
        return head.next;
    }
    
    public void TraverseLinkedList(Node head)
    {
        Node curr = head;
        while(curr != null)
        {
            Console.Write(curr.data+" -> ");
            curr = curr.next;
        }
    }
}

//Insertion at end in a linked List
using System;
class HelloWorld {
  static void Main()
  {
    LinkedList lld = new LinkedList();
    Node head = new Node(5);
    lld.Insert(10,head);
    lld.Insert(15,head);
    lld.Insert(20,head);
    
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
    public void Insert(int data, Node head)
    {
        
        Node curr = head;
        while(curr.next != null)
        {
            curr = curr.next;
        }
        
        Node newNode = new Node(data);
        curr.next = newNode;
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
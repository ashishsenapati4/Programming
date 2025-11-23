// Linked list addition
using System;
class HelloWorld {
  static void Main() {
      Node num1 = new Node(1);
      num1.next = new Node(2);
      num1.next.next = new Node(3);
      
      Node num2 = new Node(9);
      num2.next = new Node(6);
      num2.next.next = new Node(9);
      
      Node sum = AddNumsUsingLL(num1,num2);
      PrintList(sum);
  }
  
  public static Node AddNumsUsingLL(Node head1,Node head2)
  {
      head1 = ReverseLL(head1);
      head2 = ReverseLL(head2);
      
      int carry = 0;
      Node sum = null;
      
      while(head1!=null || head2 != null || carry != 0)
      {
          int newVal = carry;
          if(head1 != null)
          {
              newVal += head1.data;
              head1 = head1.next;
          }
          if(head2 != null)
          {
              newVal += head2.data;
              head2 = head2.next;
          }
          carry = newVal / 10;
          newVal = newVal % 10;
          
          Node newNode = new Node(newVal);
          newNode.next = sum;
          sum = newNode;
      }
      return (sum != null) ? sum : new Node(0);
  }
  
  public static void PrintList(Node node)
  {
      Node curr = node;
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
  
  public static Node ReverseLL(Node head)
  {
      Node prev = null;
      Node curr = head;
      Node next;
     
      while(curr != null)
      {
        next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
      }
      return prev;
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
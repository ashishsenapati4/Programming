SOLID PRINCIPLE IMPLEMENTATIONS:-
...............................

1.SINGLE RESPONSIBILITY MODEL(SRP):-
....................................

//Single Responsibility Model(Invoice Calculation and Invoice Saving are handled by 2 different classes)
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        InvoiceCalculator obj1 = new InvoiceCalculator();
        decimal total = obj1.CalculateTotal(7000,10);
        
        InvoiceRepository obj2 = new InvoiceRepository();
        obj2.SaveInvoice($"Total: {total}");
    }
}

//handles invoice calculation
public class InvoiceCalculator
{
    public decimal CalculateTotal(decimal amount, decimal tax)
    {
        return amount + (amount*tax);
    }
}

//handles invoice saving
public class InvoiceRepository
{
    public void SaveInvoice(string data)
    {
        Console.WriteLine($"Invoice saved:{data}");
    }
}

2.OPEN-CLOSED PRINCIPLE(OCP):-
..............................
//OCP(here if we need to add a new Invoice type later we can create a class and 
//    extend from the Invoice class easily. If we had only one class Invoice
//    and a method GetInvoiceDiscount() then we had to modify that method,
//    whicj is a violation)
using System;
class HelloWorld {
  static void Main() {
            Console.WriteLine("Invoice Amount: 10000");
            Invoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Final Invoice : {FInvoiceAmount}");
            Invoice PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Proposed Invoice : {PInvoiceAmount}");
            Invoice RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Recurring Invoice : {RInvoiceAmount}");
            Console.ReadKey();
  }
}
public class Invoice
{
    public virtual double GetInvoiceDiscount(double amount)
    {
        return amount - 10;
    }
}

public class FinalInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return amount - 50;
    }
}

public class ProposedInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return amount - 40;
    }
}

public class RecurringInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return amount -30;
    }
}

3. LISKOV-SUBSTITUTION PRINCIPLE(LSP):-
.......................................
Problem:-

using System;
class HelloWorld {
  static void Main() {
      Apple apple = new Orange(); //replaced parent Apple with Orange but now the Apple's colour is ORANGE.
      Console.WriteLine(apple.GetColour()); //ORANGE
  }
}

public class Apple
{
    public virtual string GetColour()
    {
        return "RED";
    }
}

public class Orange : Apple
{
    public override string GetColour()
    {
        return "ORANGE";
    }
}

SOLN:-
....

using System;
class HelloWorld {
  static void Main() {
      IFruit fruit = new Orange(); //we are using parent class reference still getting correct result
      Console.WriteLine(fruit.GetColour());
  }
}

interface IFruit
{
    string GetColour();
}

public class Apple : IFruit
{
    public string GetColour()
    {
        return "RED";
    }
}

public class Orange : IFruit
{
    public string GetColour()
    {
        return "ORANGE";
    }
}

4. INTERFACE SEGREGATION PRINCIPLE(ISP):-
.......................................
Problem:-
........
public interface BankAccount
{
	void Deposit();
    void CheckBalance();
	void Withdrawl();
}
public class SavingsAccount : BankAccount
{
    public void Deposit()
    {
        Console.WriteLine("Deposit in Savings.");
    }
    public void Withdrawl()
    {
        Console.WriteLine("Withdrawl from Savings.");
    }
    public void CheckBalance()
    {
        Console.WriteLine("Balance in savings.");
    }
}

public class FixedDepositAccount : BankAccount  //here fixed deposit account is being forced to implement Withdraw(), which is not necessary.
{
    public void Deposit()
    {
        Console.WriteLine("Deposit in Savings.");
    }
    public void Withdrawl()
    {
        throw new NotImplementedException();
    }
    public void CheckBalance()
    {
        Console.WriteLine("Balance in savings.");
    }
}
solution:-
.........
//FIXED DEPOSIT ACCOUNT IS NOT BEING FORCED TO IMPLEMENT WITHDRAWL() METHOD 
using System;
class HelloWorld {
  static void Main() {
      SavingsAccount savings = new SavingsAccount();
      savings.Deposit();
      savings.Withdrawl();
      
      FixedDepositAccount fd = new FixedDepositAccount();
      fd.Deposit();
      
  }
}

interface Account
{
    void Deposit();
    void CheckBalance();
}

interface WithdrawableAccount
{
    void Withdrawl();
}
public class SavingsAccount : Account,WithdrawableAccount
{
    public void Deposit()
    {
        Console.WriteLine("Deposit in Savings.");
    }
    public void Withdrawl()
    {
        Console.WriteLine("Withdrawl from Savings.");
    }
    public void CheckBalance()
    {
        Console.WriteLine("Balance in savings.");
    }
}

public class FixedDepositAccount : Account
{
    public void Deposit()
    {
        Console.WriteLine("Deposit in FixedDepositAccount.");
    }
    public void CheckBalance()
    {
        Console.WriteLine("Balance in FixedDepositAccount.");
    }
    
}

5.DEPENDENCY INVERSION PRINCIPLE
.................................

using System;
class HelloWorld {
  static void Main() {
      EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
      Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);
      Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
      Console.ReadKey();
  }
}

public class Employee
{
    public int Id;
    public string Name;
    public decimal Salary;
    public string Address;
}

public interface IEmployeeDataAccess
{
    Employee GetEmployeeDetails(int id);
}
public class EmployeeDataAccess : IEmployeeDataAccess
{
    public Employee GetEmployeeDetails(int id)
    {
        Employee emp = new Employee();
        emp.Id = id;
        emp.Name = "Ashish";
        emp.Salary = 78000;
        emp.Address = "BBSR";
        return emp;
    }
}
public class DataAccessFactory
{
    public static IEmployeeDataAccess GetEmployeeDataAccessObj()
    {
        return new EmployeeDataAccess();
    }
}

public class EmployeeBusinessLogic
{
    IEmployeeDataAccess _iEmployeeDataAccess;
    
    public EmployeeBusinessLogic()
    {
        _iEmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
    }
    
    public Employee GetEmployeeDetails(int id)
    {
       return  _iEmployeeDataAccess.GetEmployeeDetails(id);
    }
}

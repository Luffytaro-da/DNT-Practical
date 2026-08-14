using System;
using System.Collections.Generic;

class Expense
{
    public string Category { get; set; }
    public double Amount { get; set; }

    public Expense(string category, double amount)
    {
        Category = category;
        Amount = amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Expense> expenses = new List<Expense>();
        int choice;

        do
        {
            Console.WriteLine("\n===== Expense Tracking System =====");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Show Total Expense");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddExpense(expenses);
                        break;

                    case 2:
                        ViewExpenses(expenses);
                        break;

                    case 3:
                        ShowTotal(expenses);
                        break;

                    case 4:
                        Console.WriteLine("Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter numbers only.");
                choice = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
                choice = 0;
            }
            finally
            {
                Console.WriteLine("----------------------------------");
            }

        } while (choice != 4);
    }

    static void AddExpense(List<Expense> expenses)
    {
        try
        {
            Console.Write("Enter Expense Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Expense Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= 0)
            {
                throw new ArgumentException("Expense amount must be greater than zero.");
            }

            expenses.Add(new Expense(category, amount));
            Console.WriteLine("Expense added successfully.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid amount. Please enter a numeric value.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ViewExpenses(List<Expense> expenses)
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
            return;
        }

        Console.WriteLine("\nCategory\tAmount");

        foreach (Expense expense in expenses)
        {
            Console.WriteLine($"{expense.Category}\t\t₹{expense.Amount}");
        }
    }

    static void ShowTotal(List<Expense> expenses)
    {
        double total = 0;

        foreach (Expense expense in expenses)
        {
            total += expense.Amount;
        }

        Console.WriteLine("Total Expense = ₹" + total);
    }
}
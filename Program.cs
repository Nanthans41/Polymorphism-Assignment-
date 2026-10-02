using System;

namespace InterfaceAssignment
{
    // The IQuittable interface defines a contract that any implementing
    // class must follow. Any class that implements this interface must
    // provide its own version of the Quit() method.
    public interface IQuittable
    {
        // Declares the Quit() method without providing its implementation.
        // The implementing class will decide what this method actually does.
        void Quit();
    }

    // The Employee class represents an employee.
    // It inherits from IQuittable, which means Employee must implement
    // the Quit() method defined by the interface.
    public class Employee : IQuittable
    {
        // Stores the employee's first name.
        public string FirstName { get; set; }

        // Stores the employee's last name.
        public string LastName { get; set; }

        // Implements the Quit() method required by IQuittable.
        // In this example, the method displays a message to the console.
        public void Quit()
        {
            // Displays a message indicating that the employee has quit.
            Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
        }
    }

    // The Program class contains the Main() method, which is where
    // the console application begins running.
    internal class Program
    {
        // The Main() method is the starting point of the console application.
        static void Main(string[] args)
        {
            // Creates a new Employee object and assigns values to its properties.
            Employee employee = new Employee
            {
                FirstName = "Chris",
                LastName = "Smith"
            };

            // POLYMORPHISM:
            // Creates an object of the interface type IQuittable.
            // The Employee object can be assigned to this interface variable
            // because Employee implements IQuittable.
            IQuittable quittableEmployee = employee;

            // Calls the Quit() method through the IQuittable interface.
            // C# determines that Employee's implementation of Quit() should run.
            quittableEmployee.Quit();

            // Keeps the console window open so the user can see the output
            // before the application closes.
            Console.ReadLine();
        }
    }
}

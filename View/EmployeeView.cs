using Basic_Connections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Connections.View;

public class EmployeeView
{
    public void Output(employees employee)
    {
        Console.WriteLine("Id: " + employee.id);
        Console.WriteLine("Nik: " +employee.nik);
        Console.WriteLine("First Name: " +employee.first_name);
        Console.WriteLine("Last Name: " +employee.last_name);
        Console.WriteLine("Birth date: " +employee.birthdate);
        Console.WriteLine("Gender: " +employee.gender);
        Console.WriteLine("Hiring date: " +employee.hiring_date);
        Console.WriteLine("Email: " +employee.email);
        Console.WriteLine("Phone Number: " +employee.phone_number);
        Console.WriteLine("Department: " +employee.department);
        Console.WriteLine("-----------------------------------------");
    }
    public void Output(List<employees> employees)
    {
        foreach (var employee in employees)
        {
            Output(employee);
        }
    }

    public void Output(string message)
    {
        Console.WriteLine(message);
    }
}
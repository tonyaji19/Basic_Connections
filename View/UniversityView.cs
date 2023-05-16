using Basic_Connections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Connections.View;

public class UniversityView
{
    public void Output(universities university)
    {
        Console.WriteLine("");
        Console.WriteLine("Id: " + university.id);
        Console.WriteLine("Name: " + university.name);
        Console.WriteLine("-----------------------------------------");
    }

    public void Output(List<universities> universities)
    {
        foreach (var university in universities)
        {
            Output(university);
        }
    }

    public void Output(string message)
    {
        Console.WriteLine(message);
    }
}
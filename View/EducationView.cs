using Basic_Connections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Connections.View;
public class EducationView
{
    public void Output(Educations education)
    {
        Console.WriteLine("");
        Console.WriteLine("Id: " + education.id);
        Console.WriteLine("Major: " + education.major);
        Console.WriteLine("Degree: " + education.degree);
        Console.WriteLine("GPA: " + education.gpa);
        Console.WriteLine("Universty Id : " + education.university_id);
        Console.WriteLine("-----------------------------------------");
    }
    public void Output(List<Educations> Educations)
    {
        foreach (var education in Educations)
        {
            Output(education);
        }
    }

    public void Output(string message)
    {
        Console.WriteLine(message);
    }
}

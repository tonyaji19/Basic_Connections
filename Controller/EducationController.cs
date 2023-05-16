using Basic_Connections.Model;
using Basic_Connections.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Connections.Controller;


public class EducationController
{
    private Educations _educations = new Educations();

    public void GetAll()
    {
        var results = _educations.GetEducation();
        var view = new EducationView();
        if (results.Count == 0)
        {
            view.Output("Data Tidak Ditemukan");
        }
        else
        {
            view.Output(results);
        }

    }

}
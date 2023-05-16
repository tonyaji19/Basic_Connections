using Basic_Connections.Model;
using Basic_Connections.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Connections.Controller;

public class EmployeeController
{
    private employees _employees = new employees();

    public void GetAll()
    {
        var results = _employees.GetAllEmployee();
        var view = new EmployeeView();
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

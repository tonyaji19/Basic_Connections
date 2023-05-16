

using System.Data.SqlClient;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System;
using Basic_Connections.Model;
using Basic_Connections.Controller;
using Basic_Connections.View;
using System.Reflection.Emit;

public class Program
{
    private static UniversityController universityController = new();
    private static EducationController educationController = new();
    private static EmployeeController employeeController = new();


    private static MenuView menuView = new();

    public static void Main()
    {

        int choice;
        do
        {
            /*  var menu = new MenuView();
              menu.Insert();*/
            menuView.Menu();
            choice = Convert.ToInt32(Console.ReadLine());
            var education = new Educations();
            var university = new universities();
            var employees = new employees();
            var universities = new universities();
            var profilings = new profilings();



            switch (choice)
            {
                case 1:
                    menuView.Insert();
                    Console.Write("Pilih tabel yang akan di insert data : ");
                    int tabel = Convert.ToInt32(Console.ReadLine());
                    menuView.InsertTables(tabel);
                    break;

                case 2:
                    menuView.MenuCase2();
                    int tabel2 = Convert.ToInt32(Console.ReadLine());
                    menuView.GetAllData(tabel2);
                    break;

                case 3:
                    menuView.MenuCase3();
                    int tabel3 = Convert.ToInt32(Console.ReadLine());
                    menuView.UpdateData(tabel3);
                    break;

                case 4:
                    menuView.MenuCase4();
                    int tabel4 = Convert.ToInt32(Console.ReadLine());
                    menuView.DeleteData(tabel4);
                    break;

                case 5:
                    employees.PrintOutEmployee(universities, education, profilings);
                    break;

                case 6:
                    employees.GetAllJoin(education, profilings, universities);
                    break;

                default:
                    Console.WriteLine("Input Invalid");
                    break;
            }
        } while (choice != 7);

    }
}
using Basic_Connections.Controller;
using Basic_Connections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Connections.View;
public class MenuView
{
    public void Insert()
    {
        Console.WriteLine("1. University");
        Console.WriteLine("2. Education");
        Console.WriteLine("3. Employee");
        Console.Write("Pilih tabel yang akan di insert data : ");
    }
    public void Menu()
    {
        Console.WriteLine("=====================");
        Console.WriteLine("\tCRUD AJAH");
        Console.WriteLine("=====================");
        Console.WriteLine("1. Insert");
        Console.WriteLine("2. Select");
        Console.WriteLine("3. Update");
        Console.WriteLine("4. Delete");
        Console.WriteLine("5. Insert All");
        Console.WriteLine("6. Get All Join");
        Console.WriteLine("7. Exit");
        Console.WriteLine("=====================");
        Console.Write("Pilih menu : ");
    }
    public void MenuCase2()
    {
        Console.WriteLine("1. University");
        Console.WriteLine("2. Education");
        Console.WriteLine("3. Employee");
        Console.WriteLine("4. linq");
        Console.Write("Pilih tabel yang akan di tampilkan : ");
    }

    public void MenuCase3()
    {
        Console.WriteLine("1. University");
        Console.WriteLine("2. Education");
        Console.Write("Pilih tabel yang akan di Update : ");
    }

    public void MenuCase4()
    {
        Console.WriteLine("1. University");
        Console.WriteLine("2. Education");
        Console.Write("Pilih tabel yang akan di hapus : ");
    }

    public void InsertTables(int tabel)
    {
        UniversityController universityController = new();
        universities universities = new();

        switch (tabel)
        {
            case 1:
                Console.WriteLine("-----------------------------------------");
                var university = new universities();
                Console.Write("Masukkan nama : ");
                string nama = Console.ReadLine();
                university.name = nama;

                universityController.Insert(university);
                break;
            case 2:
                Console.WriteLine("-----------------------------------------");
                var education = new Educations();
                Console.Write("Masukkan Major : ");
                var major = Console.ReadLine();
                education.major = major;

                Console.Write("Masukkan Degree : ");
                var degree = Console.ReadLine();
                education.degree = degree;

                Console.Write("Masukkan GPA : ");
                var gpa = Console.ReadLine();
                education.gpa = gpa;

                Console.Write("University ID : ");
                var university_id = Convert.ToInt32(Console.ReadLine());
                education.university_id = university_id;

                /*var result = Education.InsertEducation(education);
                if (result > 0) {
                    Console.WriteLine("Insert success.");
                }
                else {
                    Console.WriteLine("Insert failed.");
                }*/
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }

    public void GetAllData(int tabel2)
    {
        UniversityController universityController = new();
        EducationController educationController = new();
        EmployeeController employeeController = new();

        universities universities = new();

        if (tabel2 == 1)
        {
            universityController.GetAll();
        }
        if (tabel2 == 2)
        {
            Console.WriteLine("SELECT ALL FROM EDUCATION");
            var education = new Educations();
            var results = education.GetEducation();
            foreach (var result in results)
            {
                educationController.GetAll();
            }
        }
        if (tabel2 == 3)
        {

            Console.WriteLine("SELECT ALL FROM EMPLOYEE");
            var employees = new employees();

            var results = employees.GetAllEmployee();
            foreach (var result in results)
            {
                employeeController.GetAll();

            }
        }
        if (tabel2 == 4)
        {

            Console.WriteLine("SELECT ALL by id department");
            var employees = new employees();
            var results = employees.GetAllEmployee();
            var getEmployee = results.Where(e => e.department == "04  ");
            foreach (var result in getEmployee)
            {
                result.GetDepartment();
            }
        }
        Console.ReadKey();
        Console.Clear();
    }

    public void UpdateData(int tabel3)
    {
        if (tabel3 == 1)
        {
            var university1 = new universities();
            Console.Write("Masukkan ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            university1.id = id;

            Console.Write("Masukkan Nama : ");
            var name3 = Console.ReadLine();
            university1.name = name3;
            var universities = new universities();
            var result = universities.UpdateUniversity(university1);
            if (result > 0)
            {
                Console.WriteLine("Update success");
            }
            else
            {
                Console.WriteLine("Update Failed");
            }
        }

        if (tabel3 == 2)
        {
            var education1 = new Educations();
            Console.Write("Masukkan ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Major: ");
            string major = Console.ReadLine();
            Console.Write("Degree: ");
            string degree = Console.ReadLine();
            Console.Write("GPA: ");
            string gpa = Console.ReadLine();
            Console.Write("Universty Id : ");
            int univ_id = Convert.ToInt32(Console.ReadLine());

            education1.id = id;
            education1.major = major;
            education1.degree = degree;
            education1.gpa = gpa;
            education1.university_id = univ_id;
            var education = new Educations();
            var results = education.UpdateEducation(education1);
            if (results > 0)
            {
                Console.WriteLine("Update success");
            }
            else
            {
                Console.WriteLine("Update Failed");
            }
        }
    }
    public void DeleteData(int tabel4)
    {
        if (tabel4 == 1)

        {
            var university2 = new universities();
            Console.Write("Masukkan ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            university2.id = id;
            var universities = new universities();
            var result = universities.DeleteUniversity(university2);
            if (result > 0)
            {
                Console.WriteLine("Delete success");
            }
            else
            {
                Console.WriteLine("Delete Failed");
            }
        }

        else if (tabel4 == 2)
        {
            var education2 = new Educations();
            Console.Write("Masukkan ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            education2.id = id;
            var education = new Educations();
            var result = education.DeleteEducation(education2);
            if (result > 0)
            {
                Console.WriteLine("Delete success");
            }
            else
            {
                Console.WriteLine("Delete Failed");
            }
        }
    }
}




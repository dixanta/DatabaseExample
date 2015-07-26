using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseExample.Models;
using DatabaseExample.Service;

namespace DatabaseExample
{
    class Program
    {

        static void Main(string[] args)
        {
           // DBConnection _Connection = new DBConnection(new SqlConnection());
           // _Connection.Open("Server=ENVPHOBIA;Database=LeapfrogAcademy;Trusted_Connection=True;");


            CourseService _CourseService = new CourseService();

            foreach (Course c in _CourseService.GetAll())
            {

                Console.WriteLine(c.Name);

            }


            Console.ReadKey();
            
            //Project Complete


        }
    }
}

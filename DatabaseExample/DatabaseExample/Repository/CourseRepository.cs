using DatabaseExample.DbUtility;
using DatabaseExample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample.Repository
{

    public interface ICourseRepository : IGenericRepository<Course>
    {

    }
    public class CourseRepository:ICourseRepository
    {
        DBConnection _Connection = new DBConnection(new SqlConnection("Server=ENVPHOBIA;Database=LeapfrogAcademy;Trusted_Connection=True;"));

        public List<Course> GetAll()
        {
            List<Course> _CourseList = new List<Course>();

            
            _Connection.Open();
            string sql = "SELECT * FROM Course";
            IDbCommand _Command = _Connection.InitCommand(sql, CommandType.Text);

            IDataReader reader = _Connection.ExecuteReader();

            while (reader.Read())
            {
                Course _Course = new Course();
                _Course.Id = Convert.ToInt32(reader["Id"]);
                _Course.Name = reader["Name"].ToString();
                _Course.Description = reader["Description"].ToString();


                _CourseList.Add(_Course);
               
            }

            _Connection.Close();
            return _CourseList;

        }

        public int Insert(Course t)
        {
            throw new NotImplementedException();
        }
    }
}

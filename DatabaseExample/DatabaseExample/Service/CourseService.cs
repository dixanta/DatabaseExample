using DatabaseExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseExample.Models;

namespace DatabaseExample.Service
{
    public class CourseService
    {
        ICourseRepository _CourseRepository = new CourseRepository();

        public List<Course> GetAll()
        {
            return _CourseRepository.GetAll();
        }
    }
}

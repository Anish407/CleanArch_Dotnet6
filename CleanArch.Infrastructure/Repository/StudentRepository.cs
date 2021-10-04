using CleanArch.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {

        public async Task<IEnumerable<Student>> GetAll()
        {
            return new List<Student>
            {
                new Student{  Id="1", FirstName="anish"},
                new Student{  Id="1", FirstName="anish"},
                new Student{  Id="1", FirstName="anish"},
                new Student{  Id="1", FirstName="anish"},
                new Student{  Id="1", FirstName="anish"}
            };
        }
    }
}

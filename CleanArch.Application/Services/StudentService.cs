using CleanArch.Application.Interfaces.Services;
using CleanArch.Application.Models;
using CleanArch.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class StudentService : IStudentService
    {

        public StudentService(IStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        public IStudentRepository StudentRepository { get; }

        public async Task<IEnumerable<StudentDto>> GetAllStudents()
        {
           //get data from db
            var result =await StudentRepository.GetAll();
            //domain logic
            return result.Select(i => new StudentDto { Id=i.Id, Full=$"{i.FirstName} {i.LastName}" });
        }

    }
}

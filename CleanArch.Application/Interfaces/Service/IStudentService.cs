using CleanArch.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllStudents();
    }
}
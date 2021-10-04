using CleanArch.Application.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAll();
    }
}
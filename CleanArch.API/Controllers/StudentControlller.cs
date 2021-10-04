
using CleanArch.Application.Interfaces.Services;
using CleanArch.Application.Models;
using Microsoft.AspNetCore.Mvc;


namespace CleanArch.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentControlller : ControllerBase
{
    public StudentControlller(IStudentService studentService) =>  StudentService = studentService;

    public IStudentService StudentService { get; }

    /// <summary>
    /// Returns list of students
    /// </summary>
    /// <returns></returns>
    [HttpGet("GetAllStudents")]
    public async Task<ActionResult<IEnumerable<StudentDto>>> Get() => Ok(StudentService.GetAllStudents());



}

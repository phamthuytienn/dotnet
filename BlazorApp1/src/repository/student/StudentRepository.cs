using BlazorApp1.Data;
using BlazorApp1.db;

namespace BlazorApp1.repository;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void AddStudent(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
    }

    public IEnumerable<Student> GetAllStudents()
    {
        return _context.Students.ToList();
    }

    // Other methods implementation
}
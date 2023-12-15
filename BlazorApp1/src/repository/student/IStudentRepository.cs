using BlazorApp1.Data;

namespace BlazorApp1.repository;

public interface IStudentRepository
{
    void AddStudent(Student student);

    IEnumerable<Student> GetAllStudents();
}
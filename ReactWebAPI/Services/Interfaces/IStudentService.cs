using ReactWebAPI.Model.Requests;
using ReactWebAPI.Model;

namespace ReactWebAPI.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();

        Student GetStudentById(Guid id);

        Student CreateStudent(StudentRequest student);

        Student UpdateStudent(Student student);

        Student DeleteStudent(Guid id);

        
    }
}

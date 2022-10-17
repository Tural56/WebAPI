using ReactWebAPI.Model;

namespace ReactWebAPI.Repository.Interfaces
{
    public interface IStudentRepository
    {
        public List<Student> getAll();

        public Student getById(Guid id);

        public Student createStudent(Student student);

        public Student updateStudent(Student student);

        public Student deleteStudent(Guid id);
    }
}

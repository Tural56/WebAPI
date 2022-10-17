using ReactWebAPI.Model;
using ReactWebAPI.Model.Requests;
using ReactWebAPI.Repository.Interfaces;
using ReactWebAPI.Services.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace ReactWebAPI.Services.Classes
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        public Student CreateStudent(StudentRequest student)
        {
            if (string.IsNullOrEmpty(student.Name))
            {
                return new Student();
            }
            else if (string.IsNullOrEmpty(student.des))
            {
                return new Student();
            }
            else if (string.IsNullOrEmpty(student.text))
            {
                return new Student();
            }

            Student newStudent = new Student()
            {
                
                Name = student.Name,
                des = student.des,
                text = student.text,
                Id = Guid.NewGuid(),
                group = student.group,
                surname = student.surname,
                img = student.img,

            };


            var created_news = studentRepository.createStudent(newStudent);
            return created_news;
        }

        public Student DeleteStudent(Guid id)
        {
            var delete_student = studentRepository.deleteStudent(id);
            return delete_student;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> studentList = studentRepository.getAll();
            return studentList;
        }

        public Student GetStudentById(Guid id)
        {
            var studentById = studentRepository.getById(id);
            return studentById;
        }

        

        public Student UpdateStudent(Student news)
        {
            var updated_news = studentRepository.updateStudent(news);
            return updated_news;
        }
    }
}

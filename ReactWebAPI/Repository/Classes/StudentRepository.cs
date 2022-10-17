using ReactWebAPI.Model;
using ReactWebAPI.Model.AppDbContext;
using ReactWebAPI.Repository.Interfaces;

namespace ReactWebAPI.Repository.Classes
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext db;

        public StudentRepository(AppDbContext db)
        {
            this.db = db;
        }

        public Student createStudent(Student student)
        {
            db.students.Add(student);
            db.SaveChanges();
            return student;
        }

        public Student deleteStudent(Guid id)
        {
            Student news = db.students.FirstOrDefault(x => x.Id == id);
            if (news != null)
            {

                db.students.Remove(news);
                db.SaveChanges();
                return news;
            }
            else
            {
                return new Student();
            }
        }

        public List<Student> getAll()
        {

            var news = db.students.ToList();
            if (news != null)
            {
                return news;
            }
            return new List<Student>();
        }

        public Student getById(Guid id)
        {
            Student news = db.students.FirstOrDefault(x => x.Id == id);
            if (news != null)
            {
                return news;
            }
            return new Student();
        }

        public Student updateStudent(Student student)
        {
            if (student != null)
            {
                db.students.Update(student);
                return student;
            }

            return new Student();
        }
    }
}

using ReactWebAPI.Model;
using ReactWebAPI.Repository.Classes;
using ReactWebAPI.Repository.Interfaces;
using ReactWebAPI.Services.Interfaces;

namespace ReactWebAPI.Services.Classes
{
    public class VacancyService : IVacancyService
    {
        private readonly IVacancyRepository vacancyRepository;
        public Vacancy CreateVacancy(Vacancy vacancy)
        {
            if (string.IsNullOrEmpty(vacancy.Name))
            {
                return new Vacancy();
            }
            else if (string.IsNullOrEmpty(vacancy.des))
            {
                return new Vacancy();
            }
            

            //Vacancy newVacancy = new Student()
            //{

            //    Name = vacancy.Name,
            //    des = vacancy.des,
            //    text = vacancy.text,
            //    Id = Guid.NewGuid(),
            //    group = vacancy.group,
            //    surname = vacancy.surname,
            //    img = vacancy.img,
            //};


            var created_vacancy = vacancyRepository.CreateVacancy(vacancy);
            return created_vacancy;
        }

        public Vacancy DeleteVacancy(Guid id)
        {
            var delete_vacancy = vacancyRepository.DeleteVacancy(id);
            return delete_vacancy;
        }

        public List<Vacancy> GetAllVacancy()
        {
            List<Vacancy> vacancyList = vacancyRepository.GetAllVacancy();
            return vacancyList;
        }

        public Vacancy GetVacancyById(Guid id)
        {
            var vacancyById = vacancyRepository.GetVacancy(id);
            return vacancyById;
        }

        public List<Vacancy> OrderByTime()
        {
            var vacancyList = vacancyRepository.OrderByTime().ToList();
            return vacancyList;
        }

        public Vacancy UpdateVacancy(Vacancy vacancy)
        {
            var updated_vacancy = vacancyRepository.UpdateVacany(vacancy);
            return updated_vacancy;
        }
    }
}

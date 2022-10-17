using ReactWebAPI.Model;
using ReactWebAPI.Model.AppDbContext;
using ReactWebAPI.Repository.Interfaces;

namespace ReactWebAPI.Repository.Classes
{
    public class VacancyRepository : IVacancyRepository
    {
        private readonly AppDbContext db;

        public VacancyRepository(AppDbContext db)
        {
            this.db = db;
        }

        public Vacancy CreateVacancy(Vacancy newVacancy)
        {
            db.vacancies.Add(newVacancy);
            db.SaveChanges();
            return newVacancy;
        }

        public Vacancy DeleteVacancy(Guid id)
        {
            Vacancy vacancy = db.vacancies.FirstOrDefault(x => x.VacancyId == id);
            if (vacancy != null)
            {

                db.vacancies.Remove(vacancy);
                db.SaveChanges();
                return vacancy;
            }
            else
            {
                return new Vacancy();
            }
        }

        public List<Vacancy> GetAllVacancy()
        {
            var vacancies = db.vacancies.ToList();
            if (vacancies != null)
            {
                return vacancies;
            }
            return new List<Vacancy>();
        }

        public Vacancy GetVacancy(Guid id)
        {
            Vacancy vacancy = db.vacancies.FirstOrDefault(x => x.VacancyId == id);
            if (vacancy != null)
            {
                return vacancy;
            }
            return new Vacancy();
        }

        public List<Vacancy> OrderById()
        {
            var list = db.vacancies.OrderBy(x => x.VacancyId).ToList();
            if (list != null)
            {
                return list;
            }
            return new List<Vacancy>();
        }

        public Vacancy UpdateVacany(Vacancy newVacancy)
        {
            if (newVacancy != null)
            {
                db.vacancies.Update(newVacancy);
                return newVacancy;
            }

            return new Vacancy();
        }

        public List<Vacancy> OrderByTime()
        {
            var list = db.vacancies.OrderBy(x => x.sending_Time).ToList();
            if (list != null)
            {
                return list;
            }
            return new List<Vacancy>();
        }
    }
}

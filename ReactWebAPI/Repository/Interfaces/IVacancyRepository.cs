using ReactWebAPI.Model;

namespace ReactWebAPI.Repository.Interfaces
{
    public interface IVacancyRepository
    {
        List<Vacancy> GetAllVacancy();

        Vacancy GetVacancy(Guid id);

        List<Vacancy> OrderById();

        Vacancy CreateVacancy(Vacancy newVacancy);

        List<Vacancy> OrderByTime();

        Vacancy UpdateVacany(Vacancy newVacancy);

        Vacancy DeleteVacancy(Guid id);
    }
}

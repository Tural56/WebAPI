using ReactWebAPI.Model.Requests;
using ReactWebAPI.Model;

namespace ReactWebAPI.Services.Interfaces
{
    public interface IVacancyService
    {
        List<Vacancy> GetAllVacancy();

        Vacancy GetVacancyById(Guid id);

        Vacancy CreateVacancy(Vacancy vacancy);

        List<Vacancy> OrderByTime();

        Vacancy UpdateVacancy(Vacancy vacancy);

        Vacancy DeleteVacancy(Guid id);
    }
}

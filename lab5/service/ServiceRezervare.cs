using lab5.Domain;
using lab5.Repository;

namespace lab5.Service
{
    public class ServiceRezervare
    {
        private RezervareRepository repo;

        public ServiceRezervare(RezervareRepository repo)
        {
            this.repo = repo;
        }

        public void AddRezervare(Excursie ex, string nume, string telefon, int bilet)
        {
            Rezervare rezervare = new Rezervare(1,ex, nume, telefon, bilet);
            repo.Save(rezervare);
        }

        public void DeleteRezervare(int id)
        {
            repo.Delete(id);
        }

        public void UpdateRezervare(int id, Excursie ex, string nume, string telefon, int bilet)
        {
            Rezervare rezervare = new Rezervare(id, ex, nume, telefon, bilet);
            repo.Update(rezervare);
        }

        public IEnumerable<Rezervare> GetAllRezervari()
        {
            return repo.FindAll();
        }

        public Rezervare GetRezervare(int id)
        {
            return repo.FindOne(id);
        }
    }
}
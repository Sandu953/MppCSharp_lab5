using System;
using lab5.Domain;
using lab5.Repository;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using lab5.Domain;
using lab5.Repository;

namespace lab5.Service
{
    public class ServiceExcursie
    {
        private ExcursieRepository excursieRepo;

        public ServiceExcursie(ExcursieRepository excursieRepo)
        {
            this.excursieRepo = excursieRepo;
        }

        public void AddExcursie(long id, string obiectiv, string firmaTransport, DateTime oraPlecare, int nrLocuriDisponibile, int pret, int locuriLibere)
        {
            Excursie ex = new Excursie(id,obiectiv, firmaTransport, oraPlecare.ToString(), pret, nrLocuriDisponibile, locuriLibere);
            ex.Id = id;
            excursieRepo.Save(ex);
        }

        public void DeleteExcursie(long id)
        {
            excursieRepo.Delete((int)id);
        }

        public Excursie GetExcursie(long id)
        {
            return excursieRepo.FindOne((int)id);
        }

        public IEnumerable<Excursie> GetAllExcursii()
        {
            return excursieRepo.FindAll().ToList();
        }

        public void UpdateExcursie(long id, string obiectiv, string firmaTransport, DateTime oraPlecare, int nrLocuriDisponibile, int pret, int locuriLibere)
        {
            Excursie ex = new Excursie(id, obiectiv, firmaTransport, oraPlecare.ToString(),  pret,nrLocuriDisponibile, locuriLibere);
           
            excursieRepo.Update( ex);
        }

        public IEnumerable<Excursie> GetExcursiiBetweenHours(string obiectiv, long ora1, long ora2)
        {
            return excursieRepo.findBeetwenHours(ora1.ToString(), ora2.ToString(),obiectiv);
        }

        public int GetFreeSeats(int id)
        {
       
            return excursieRepo.findLocuriLibere(id);
            
        }
    }
}
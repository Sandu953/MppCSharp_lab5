using lab5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5.Domain;

namespace lab5.Repository
{
    internal interface IExcursieRepo : IRepository<long, Excursie>
    {
        List<Excursie> findBeetwenHours(string ora1, string ora2, string obiectiv);

        int findLocuriLibere(int id);
    }
}

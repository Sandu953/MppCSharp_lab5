using lab5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5.Domain;

namespace lab5.Repository
{
    public interface IAgentieRepo : IRepository<long, Agentie>
    {
        bool loginByUsernamePassword(string username, string password);

        void save(string username, string password);

    }
}

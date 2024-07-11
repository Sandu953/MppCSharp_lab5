using lab5.Domain;
using lab5.Repository;

namespace lab5.Service
{
    public class ServiceAgentie
    {
        private AgentieRepository agentieRepo;

        public ServiceAgentie(AgentieRepository agentieRepo)
        {
            this.agentieRepo = agentieRepo;
        }

        public void SaveAgentie(string username, string password)
        {
            agentieRepo.save(username, password);
        }

        public Agentie DeleteAgentie(int id)
        {
            Agentie agentie = agentieRepo.FindOne(id);
            agentieRepo.Delete(id);
            return agentie;
        }

        public Agentie GetAgentie(int id)
        {
            return agentieRepo.FindOne(id);
        }

        public IEnumerable<Agentie> GetAllAgentii()
        {
            return agentieRepo.FindAll();
        }

        public void UpdateAgentie(int id, string username, string password)
        {
            Agentie agentie = new Agentie(id,username);
            //agentie.Id = id;
            agentieRepo.Update(agentie);
        }

        public bool HandleLogin(string username, string password)
        {
            return agentieRepo.loginByUsernamePassword(username, password);
        }
    }
}
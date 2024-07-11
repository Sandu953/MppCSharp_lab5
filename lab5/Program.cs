using lab5.Domain;
using lab5.Repository;
using lab5.Service;
using System;
using System.Windows.Forms;
using lab5.Controller;


namespace lab5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            string connectionString = "Data Source=C:/Users/probook/Desktop/EXAMEN MAP/mpp-proiect-java-Sandu953/FirmaExcursie.db;Version=3;";
            ExcursieRepository excursieRepository = new ExcursieRepository(connectionString);
            RezervareRepository rezervareRepository = new RezervareRepository(connectionString, excursieRepository);
            AgentieRepository agentieRepository = new AgentieRepository(connectionString);

            ServiceExcursie serviceExcursie = new ServiceExcursie(excursieRepository);
            ServiceRezervare serviceRezervare = new ServiceRezervare(rezervareRepository);
            ServiceAgentie serviceAgentie = new ServiceAgentie(agentieRepository);

            ApplicationConfiguration.Initialize();
            Login login = new Login();
            login.SetService(serviceAgentie, serviceExcursie, serviceRezervare);

            
            Application.Run(login);

        }
    }
}
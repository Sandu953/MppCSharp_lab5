using System;
using System.Windows.Forms;
using lab5.Domain;
using lab5.Repository;
using lab5.Service;





namespace lab5.Controller
{
    public partial class Login : Form
    {
        private ServiceAgentie serviceAgentie;
        private ServiceExcursie serviceExcursie;
        private ServiceRezervare serviceRezervare;

        public Login()
        {
            InitializeComponent();
        }

        public void SetService(ServiceAgentie serviceAgentie, ServiceExcursie serviceExcursie, ServiceRezervare serviceRezervare)
        {
            this.serviceAgentie = serviceAgentie;
            this.serviceExcursie = serviceExcursie;
            this.serviceRezervare = serviceRezervare;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = textBox1.Text ?? "Numele utilizatorului lipsește";
                string pass = textBox2.Text ?? "Parola lipsește";
                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    throw new Exception("Numele utilizatorului sau parola nu poate fi gol.");
                }
                if (serviceAgentie.HandleLogin(user, pass))
                {
                    RezervareView rezervareController = new RezervareView();
                    rezervareController.SetService(serviceExcursie, serviceRezervare);
                    rezervareController.Show();
                }
                else
                {
                    MessageBox.Show("Username sau parola incorecte!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la logare!" + ex.Message);
                //throw new Exception( ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}

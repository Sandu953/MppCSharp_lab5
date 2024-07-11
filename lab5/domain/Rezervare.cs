using lab5.Domain;
using System;

namespace lab5.Domain
{
    public class Rezervare : Entity<long>
    {
        private Excursie excursie;
        private string numeClient;
        private string nrTelefon;
        private int nrLocuri;

        public Rezervare(long id, Excursie excursie, string numeClient, string nrTelefon, int nrLocuri):  base(id)
        {
            this.excursie = excursie;
            this.numeClient = numeClient;
            this.nrTelefon = nrTelefon;
            this.nrLocuri = nrLocuri;
        }

        public Excursie Excursie
        {
            get { return excursie; }
            set { excursie = value; }
        }

        public string NumeClient
        {
            get { return numeClient; }
            set { numeClient = value; }
        }

        public string NrTelefon
        {
            get { return nrTelefon; }
            set { nrTelefon = value; }
        }

        public int NrLocuri
        {
            get { return nrLocuri; }
            set { nrLocuri = value; }
        }
    }
}
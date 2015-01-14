using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageFormateurs
{
  public   class Formateur
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string matricule;

        public string Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        private DateTime datenaissance;

        public DateTime Datenaissance
        {
            get { return datenaissance; }
            set { datenaissance = value; }
        }

        private string profilImage;

        public string ProfilImage
        {
            get { return profilImage; }
            set { profilImage = value; }
        }
        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        private string tél;

        public string Tél
        {
            get { return tél; }
            set { tél = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private Boolean sexe;

        public Boolean Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }


        private string cin;

        public string Cin
        {
            get { return cin; }
            set { cin = value; }
        }
        public Formateur()
        {

        }
    }
}

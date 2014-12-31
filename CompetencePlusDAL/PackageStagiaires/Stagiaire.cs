using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageGroupes;
using CompetencePlus.PackageFilieres;


namespace CompetencePlus.PackageStagiaires
{
    public class Stagiaire
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
        private DateTime dateNaissance;

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }
        private bool sexe;

        public bool Sexe
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
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

       
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        private string profilImage;

        public string ProfilImage
        {
            get { return profilImage; }
            set { profilImage = value; }
        }

        Filiere filiere;

        public Filiere Filiere
        {
            get { return filiere; }
            set { filiere = value; }
        }
        private int etat;

        public int Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        public Stagiaire()
        {
           
        }

       
    }
}

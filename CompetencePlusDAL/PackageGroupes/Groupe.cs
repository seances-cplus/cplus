using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageFilieres;
using CompetencePlus.PackageAnneeFormations;


namespace CompetencePlus.PackageGroupes
{
    public class Groupe
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private Filiere filiere;

        public Filiere Filiere
        {
            get { return this.filiere; }
            set { this.filiere = value; }
        }
        private AnneeFormation anneeFormation;

        public AnneeFormation AnneeFormation
        {
            get { return anneeFormation; }
            set { anneeFormation = value; }
        }

        public Groupe()
        {
           
        }

        public Groupe(int id, string nom)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.nom =nom;
        }
        public override string ToString()
        {
            return this.nom ;
        }
    }
}

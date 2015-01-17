using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageAnneeFormations
{
  public class AnneeFormation
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        DateTime dateDebut;

        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }
        DateTime dateFin;

        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Outils;
using CompetencePlus.Tools;
using System.Data.OleDb;

namespace CompetencePlus.PackageAnneeFormations
{
   public class AnneeFormationDAO :IGestion<AnneeFormation>
    {

        public void Add(AnneeFormation A)
        {

            string Requete = "insert into AnneeFormations(titre,dateDebut,dateFin) values('" + A.Title + "','"+A.DateDebut+"','"+A.DateFin+"')";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public void Update(AnneeFormation A)
        {
            string Requete = "Update AnneeFormations set Titre ='"+A.Title+"',dateDebut ='"+A.DateDebut+"',DateFin='"+A.DateFin+"' where id ="+A.Id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AnneeFormation> Select()
        {
            string Requete ="Select * from AnneeFormations";
            List<AnneeFormation> ListAnneeFormation = new List<AnneeFormation>();
             OleDbDataReader Read = MyConnection.ExecuteReader(Requete);
            while (Read.Read())
            {
                AnneeFormation A = new AnneeFormation();
                A.Id = Read.GetInt32(0);
                A.Title = Read.GetString(1);
                A.DateDebut = Read.GetDateTime(2);
                A.DateFin = Read.GetDateTime(3);
                ListAnneeFormation.Add(A);
                
            }

            MyConnection.Close();

            return ListAnneeFormation;
        }

        public AnneeFormation FindById(int id)
        {
            string Requete = "Select * from AnneeFormations where id="+id;
           
            OleDbDataReader Read = MyConnection.ExecuteReader(Requete);
            Read.Read();
                AnneeFormation A = new AnneeFormation();
                A.Id = Read.GetInt32(0);
                A.Title = Read.GetString(1);
                A.DateDebut = Read.GetDateTime(2);
                A.DateFin = Read.GetDateTime(3);



                return A;
            MyConnection.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Tools;
using System.Data.OleDb;
using CompetencePlus.Outils;

namespace CompetencePlus.PackageFormateurs
{
    public class FormateurDAO : IGestion<Formateur>
    {

        public void Add(Formateur f)
        {
            string Requete = "Insert into Formateurs(Nom,Prenom,Matricule,DateNaissance,Images,Tél,Email,CIN,Sexe,Adresse) values ('" + f.Nom + "','" + f.Prenom + "','" + f.Matricule + "','" + f.Datenaissance + "','" + f.ProfilImage + "','" + f.Tél + "','" + f.Email + "','" + f.Cin + "'," + 1 + ",'" + f.Adresse + "')";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public void Update(Formateur f)
        {
            string Requete = "Update Formateurs set Nom ='" + f.Nom + "',Prenom ='" + f.Prenom + "',Matricule='" + f.Matricule + "',DateNaissance='" + f.Datenaissance + "',Image ='" + f.ProfilImage + "',Tél='" + f.Tél + "',Email='" + f.Email + "',CIN='" + f.Cin + "',Sexe='" + f.Sexe + "'," + f.Adresse + " where ID =" + f.Id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public void Delete(int id)
        {
            string Requete = "Delete From Formateurs where ID=" + id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public List<Formateur> Select()
        {
            string Requete = "Select * from Formateurs";
            List<Formateur> ListFormateur = new List<Formateur>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                Formateur f = new Formateur();
                f.Id = read.GetInt32(0);
                f.Nom = read.GetString(1);
                f.Prenom = read.GetString(2);
                f.Matricule = read.GetString(3);
                f.Datenaissance = read.GetDateTime(4);

                f.ProfilImage = read.GetString(5);
                f.Tél = read.GetString(6);
                f.Email = read.GetString(7);
                f.Cin = read.GetString(8);
                f.Sexe = read.GetBoolean(9);
                f.Adresse = read.GetString(10);
                ListFormateur.Add(f);
            }
            MyConnection.Close();
            return ListFormateur;
        }


        public Formateur FindById(int id)
        {
            List<Formateur> ListFormateur = new List<Formateur>();
            string Requete = "Select * from Formateurs where id=" + id;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            Formateur f = new Formateur();
            f.Id = read.GetInt32(0);
            f.Nom = read.GetString(1);
            f.Prenom = read.GetString(2);
            f.Matricule = read.GetString(3);
            f.Datenaissance = read.GetDateTime(4);

            f.ProfilImage = read.GetString(5);
            f.Tél = read.GetString(6);
            f.Email = read.GetString(7);
            f.Cin = read.GetString(8);
            f.Sexe = read.GetBoolean(9);
            f.Adresse = read.GetString(10);


            return f;
        }
        public Formateur FindByName(string Name)
        {
            List<Formateur> ListFormateur = new List<Formateur>();
            string Requete = "Select * from Formateurs where Nom=" + Name;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            Formateur f = new Formateur();
            f.Id = read.GetInt32(0);
            f.Nom = read.GetString(1);
            f.Prenom = read.GetString(2);
            f.Matricule = read.GetString(3);
            f.Datenaissance = read.GetDateTime(4);

            f.ProfilImage = read.GetString(5);
            f.Tél = read.GetString(6);
            f.Email = read.GetString(7);
            f.Cin = read.GetString(8);
            f.Sexe = read.GetBoolean(9);
            f.Adresse = read.GetString(10);
            ListFormateur.Add(f);

            return f;
        }



        /// <summary>
        /// Recherche par Nom, Prenom, et Matricule
        /// </summary>
        /// <param name="formateur"></param>
        /// <returns></returns>
        public List<Formateur> FindByFormateur(Formateur formateur)
        {

            string Requete = "Select * from Formateurs ";
            if (formateur.Nom != "" || formateur.Prenom != "" || formateur.Matricule != "")
            {
                Requete += " where ";
            }
            bool and = false;
            if (formateur.Nom != "")
            {
                Requete += " Nom like '%" + formateur.Nom + "%'";
                and = true;
            }
            if (formateur.Prenom != "")
            {
                if (and) Requete += " and ";
                Requete += " Prenom like '%" + formateur.Prenom + "%'";
                and = true;
            }
            if (formateur.Matricule != "")
            {
                if (and) Requete += " and ";
                Requete += " Matricule like '%" + formateur.Matricule + "%'";
                and = true;
            }



            List<Formateur> ListFormateur = new List<Formateur>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                Formateur f = new Formateur();
                f.Id = read.GetInt32(0);
                f.Nom = read.GetString(1);
                f.Prenom = read.GetString(2);
                f.Matricule = read.GetString(3);
                f.Datenaissance = read.GetDateTime(4);

                f.ProfilImage = read.GetString(5);
                f.Tél = read.GetString(6);
                f.Email = read.GetString(7);
                f.Cin = read.GetString(8);
                f.Sexe = read.GetBoolean(9);
                f.Adresse = read.GetString(10);
                ListFormateur.Add(f);


            }
            MyConnection.Close();
            return ListFormateur;
        }
    }
}

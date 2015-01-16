﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Outils;
using CompetencePlus.PackageFilieres;
using CompetencePlus.Tools;


namespace CompetencePlus.PackageStagiaires
{
    public class StagiaireDAO : IGestion<Stagiaire>
    {
        public  void Add(Stagiaire s)
        {
            string Requete = "insert into stagiaires(Nom,Prenom,DateNaissance,sexe,Cin,Email,Telephone,Adress,ProfilImage,Etat,Filiere_id) values ('" +
                s.Nom + "','" + s.Prenom + "','" + s.DateNaissance + "'," + s.Sexe + ",'" + s.Cin + "','" + s.Email + "','" + s.Telephone + "','" + s.Adresse + "','" +
                s.ProfilImage + "'," + s.Etat +","+s.Filiere.Id+")";
 
            MyConnection.ExecuteNonQuery(Requete);
        }
        public void Update(Stagiaire s)
        {
            String Requete = "Update Stagiaires set Nom='"+s.Nom+"',Prenom='"+s.Prenom+"',DateNaissance='"+s.DateNaissance+"',Sexe="+s.Sexe+
                ",Cin='" + s.Cin + "',Email='" + s.Email + "',Telephone ='" + s.Telephone + "',Adress='" + s.Adresse + "',profilImage = '" + s.ProfilImage + "',Filiere_id=" + s.Filiere.Id + " where id=" + s.Id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void UpdateStat(int id)
        {
            String Requete = "Update Stagiaires set Etat= 1 where id =" + id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void Delete(int id)
        {
            String Requete = "Delete from Stagiaires where id =" + id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  List<Stagiaire> Select()
        {
            List<Stagiaire> ListStagiaires = new List<Stagiaire>();
            String Requete = "Select * from Stagiaires where etat =1";
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                Stagiaire s = new Stagiaire();
                s.Id = read.GetInt32(0);
                s.Filiere = new FiliereDAO().FindById(read.GetInt32(1));
                s.Nom = (string) read["Nom"];
                s.Prenom = (string)read["Prenom"];
                s.DateNaissance = (DateTime)read["DateNaissance"];
                s.Sexe = read.GetInt32(5);
                s.Cin = read.GetString(6);
                s.Email = read.GetString(7);
                s.Telephone = read.GetString(8);
                s.Adresse = read.GetString(9);
                try
                {
                    s.ProfilImage = read.GetString(10);
                }
                catch (Exception )
                {
                    
                }
                
                s.Etat = read.GetInt32(11);
                ListStagiaires.Add(s);


            }


            return ListStagiaires;
        }

        public  List<Stagiaire> SelectNotConfirm()
        {
            List<Stagiaire> ListStagiaires = new List<Stagiaire>();
            String Requete = "Select * from Stagiaires where etat =0";
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                Stagiaire s = new Stagiaire();
                s.Id = read.GetInt32(0);
                s.Filiere = new FiliereDAO().FindById(read.GetInt32(1));
                s.Nom = (string)read["Nom"];
                s.Prenom = (string)read["Prenom"];
                s.DateNaissance = (DateTime)read["DateNaissance"];
                s.Sexe = read.GetInt32(5);
                s.Cin = read.GetString(6);
                s.Email = read.GetString(7);
                s.Telephone = read.GetString(8);
                s.Adresse = read.GetString(9);
                s.ProfilImage = read.GetString(10);
                s.Etat = read.GetInt32(11);
                ListStagiaires.Add(s);


            }


            return ListStagiaires;

        }

        public Stagiaire FindById(int id)
        {
            throw new NotImplementedException();
        }


       
    }
}

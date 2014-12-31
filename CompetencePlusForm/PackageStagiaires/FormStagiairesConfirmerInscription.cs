using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageGroupes;
using CompetencePlus.PackageFilieres;

namespace CompetencePlus.PackageStagiaires
{
    public partial class FormStagiairesConfirmerInscription : Form
    {
        public FormStagiairesConfirmerInscription()
        {
            InitializeComponent();
        }
        string Url;
        public void Update(Stagiaire s)
        {
            pictureBox1.Image = Image.FromFile(s.ProfilImage);
            NomLab.Text = s.Nom;
            PrenomLab.Text = s.Prenom;
            DateNaissanceLab.Text = s.DateNaissance.ToString();
            if (s.Sexe)
            {
                SexeLab.Text = "Male";
            }
            else SexeLab.Text = "Femalle";
            
            CinLab.Text = s.Cin;
            FiliereLab.Text = s.Filiere.Titre;
            EmailLab.Text = s.Email;
            TelephoneLab.Text = s.Telephone;
            AdresseLab.Text = s.Adresse;
            this.Url = s.ProfilImage;

        }
        public FormStagiairesInscription Formu { get; set; }
        private void FormStagiairesConfirmerInscription_Load(object sender, EventArgs e)
        {

        }

        private void BtConfirmer_Click_1(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.Id = 1;
            s.Nom = NomLab.Text;
            s.Prenom = PrenomLab.Text;
            s.DateNaissance = DateTime.Parse(DateNaissanceLab.Text);
            if (SexeLab.Text == "Male")
            {
                s.Sexe = true;
            }
            else s.Sexe = false;
            s.Cin = CinLab.Text;
            s.Filiere = new FiliereBAO().FindByName(FiliereLab.Text);
            s.Email = EmailLab.Text;
            s.Telephone = TelephoneLab.Text;
            s.Adresse = AdresseLab.Text;
            s.Etat = 0;
            s.ProfilImage = @Url;
            StagiaireBAO.Add(s);
            this.Dispose();
            Formu.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Formu.Show();
        }
    }
}

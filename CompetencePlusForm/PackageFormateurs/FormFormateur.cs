using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageFormateurs
{
    public partial class FormFormateur : Form
    {
        public FormFormateur()
        {
            InitializeComponent();
        }
        string Url;
        public void Update(string Url, string nom, string prenom, string matricule, string datenaissance, string telephone, string adresse, string sexe, string email, string cin)
        {
            pictureBx.Image = Image.FromFile(Url);
            labNom.Text = nom;
            labPrenom.Text = prenom;
            labMatricule.Text = matricule;
            labDete.Text = datenaissance;
            labAdresse.Text = adresse;
            labTel.Text = telephone;
            labSexe.Text = sexe;
            labEmail.Text = email;
            labCin.Text = cin;
            this.Url = @Url;
        }

        private void BtValide_Click(object sender, EventArgs e)
        {
            Formateur formateur = new Formateur();
            formateur.Id = 1;
            formateur.Nom = TxtNom.Text;
            formateur.Prenom = txtPenom.Text;
            formateur.Matricule = txtMatricule.Text;
            formateur.Datenaissance = DateTime.Parse(dateTimeNaissance.Text);

            string sexe;
            if (radioButtonSexe.Checked)
            {
                sexe = "Male";
            }
            else
                sexe = "Femlle";
            formateur.Adresse = txtAdresse.Text;
            formateur.Email = txtEmail.Text;
            formateur.Cin = txtCIN.Text;
            formateur.Tél = txtTel.Text;
            formateur.ProfilImage = @Url;
            FormateurBAO.Add(formateur);
            this.Dispose();

        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void Btpicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBx.Image = Image.FromFile(openFileDialog1.FileName);
            Url = openFileDialog1.FileName;
        }
        private void FormFormateur_Load(object sender, EventArgs e)
        {

        }
    }
}

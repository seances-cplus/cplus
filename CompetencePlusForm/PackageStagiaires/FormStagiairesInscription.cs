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
    public partial class FormStagiairesInscription : Form
    {
        public FormStagiairesInscription()
        {
            InitializeComponent();
        }
        string Url;

        private void BtProfilImage_Click(object sender, EventArgs e)
        {
            openImageDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(openImageDialog.FileName);
            Url = openImageDialog.FileName;
        }

        private void FormStagiairesInscription_Load(object sender, EventArgs e)
        {
            FilierecomboBox.DataSource = new FiliereBAO().Select();
        }

        private void BtValide_Click_1(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.Nom = nomTextBox.Text;
            s.Prenom = PrenomTextBox.Text;
            s.ProfilImage = Url;
            s.Telephone = telephoneTextBox.Text;
            if (sexeRadioButton.Checked)
            {
                s.Sexe = true;
            }
            else s.Sexe = false;
            s.Cin = CinTextBox.Text;
            s.DateNaissance = dateNaissanceDateTimePicker.Value;
            s.Email = emailTextBox.Text;
            s.Adresse = adresseTextBox.Text;
            s.Filiere =(Filiere)FilierecomboBox.SelectedItem;

            FormStagiairesConfirmerInscription f = new FormStagiairesConfirmerInscription();
            f.Update(s);
            f.Formu = this;
            f.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

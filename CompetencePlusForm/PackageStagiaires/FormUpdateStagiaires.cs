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
    public partial class FormUpdateStagiaires : Form
    {
        public FormUpdateStagiaires()
        {
            InitializeComponent();
        }
        String Url;
        int id;
        public void Update(Stagiaire s) {
            id = s.Id;
            Url = s.ProfilImage;
            pictureBox1.Image = Image.FromFile(s.ProfilImage);
            nomTextBox.Text = s.Nom;
            PrenomTextBox.Text = s.Prenom;
            dateNaissanceDateTimePicker.Value = s.DateNaissance;
            CinTextBox.Text = s.Cin;
            emailTextBox.Text = s.Email;
            telephoneTextBox.Text = s.Telephone;
            adresseTextBox.Text = s.Adresse;
            if (s.Sexe == true)
            {
                sexeRadioButton.Checked = true;
            }
            else SexeRadioButton2.Checked = true;


            
        
        }

        private void FormUpdateStagiaires_Load(object sender, EventArgs e)
        {
          
            FilierecomboBox.DataSource = new FiliereBAO().Select();
        }

        private void BtValide_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.Id = id;
            s.Nom = nomTextBox.Text;
            s.Prenom = PrenomTextBox.Text;
            s.DateNaissance = dateNaissanceDateTimePicker.Value;
            s.Cin = CinTextBox.Text;
            if (sexeRadioButton.Checked == true)
            {
                s.Sexe = true;
            }
            else s.Sexe = false;
            s.Filiere = new FiliereBAO().FindByName(FilierecomboBox.Text);
            s.Email = emailTextBox.Text;
            s.Telephone = telephoneTextBox.Text;
            s.Adresse = adresseTextBox.Text;
            s.Etat = 0;
            s.ProfilImage = @Url;
            new StagiaireBAO().Update(s);
            this.Dispose();
        }

        private void BtProfilImage_Click(object sender, EventArgs e)
        {
            openImageDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(openImageDialog.FileName);
            Url = openImageDialog.FileName;
        }
    }
}

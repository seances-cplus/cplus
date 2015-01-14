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
    public partial class FormUpdateFormateur : Form
    {
        public FormUpdateFormateur()
        {
            InitializeComponent();
        }
        string Url;
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

        private void Btpicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBx.Image = Image.FromFile(openFileDialog1.FileName);
            Url = openFileDialog1.FileName;
        }

        private void FormUpdateFormateur_Load(object sender, EventArgs e)
        {

        }
    }
}

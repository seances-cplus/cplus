using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageStagiaires
{
    public partial class FormGestionInscription : Form
    {
        public FormGestionInscription()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            stagiaireBindingSource.DataSource = null;
            stagiaireBindingSource.DataSource = new StagiaireBAO().SelectNotConfirm(); ;
        }

        private void FirstRow_Click(object sender, EventArgs e)
        {
            stagiaireBindingSource.Position = 0;
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Filiere.Text = s.Filiere.Titre;
            }
            catch (Exception)
            {
            }
        }

        private void PriviousRow_Click(object sender, EventArgs e)
        {
            stagiaireBindingSource.Position = stagiaireBindingSource.Position - 1;
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Filiere.Text = s.Filiere.Titre;
            }
            catch (Exception)
            {
            }
        }

        private void NextRow_Click(object sender, EventArgs e)
        {
            stagiaireBindingSource.Position = stagiaireBindingSource.Position + 1;
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Filiere.Text = s.Filiere.Titre;
            }
            catch (Exception)
            {
            }
        }

        private void LastRow_Click(object sender, EventArgs e)
        {
            stagiaireBindingSource.Position = stagiaireBindingSource.Count;
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Filiere.Text = s.Filiere.Titre;
            }
            catch (Exception)
            {
            }
        }

        private void stagiaireDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 3)
                {
                    Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                    new StagiaireBAO().UpdateStat(s.Id);
                    this.Actualiser();
                }
                if (e.ColumnIndex == 4)
                {
                    Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                    FormUpdateStagiaires f = new FormUpdateStagiaires();
                    f.Update(s);
                    f.ShowDialog();
                    this.Actualiser();
                }
                if (e.ColumnIndex == 5)
                {
                    Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                    new StagiaireBAO().Delete(s.Id);
                    this.Actualiser();
                }
                Stagiaire x = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(x.ProfilImage);
                Nom.Text = x.Nom;
                prenom.Text = x.Prenom;
                Filiere.Text = x.Filiere.Titre;
            }
            catch (Exception)
            {

            }
        }

        private void FormGestionInscription_Load(object sender, EventArgs e)
        {
            this.Actualiser();
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Filiere.Text = s.Filiere.Titre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

       
    }
}

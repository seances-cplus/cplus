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
    public partial class FormGestionFormateur : Form
    {
        public FormGestionFormateur()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            formateurBindingSource.DataSource = null;
            formateurBindingSource.DataSource = new FormateurBAO().Select();
        }

        private void BtRechercher_Click(object sender, EventArgs e)
        {
            Formateur formateur = new Formateur();
            formateur.Nom = txtNom.Text;
            formateur.Prenom = txtPrenom.Text;
            formateur.Matricule = txtMatricule.Text;
            formateurBindingSource.DataSource = null;
            formateurBindingSource.DataSource = new FormateurBAO().FindByFormateur(formateur);
        }

        private void btDebut_Click(object sender, EventArgs e)
        {
            formateurBindingSource.MoveFirst();

        }

        private void btPrecedent_Click(object sender, EventArgs e)
        {
            formateurBindingSource.MovePrevious();
        }

        private void BtSuivant_Click(object sender, EventArgs e)
        {
            formateurBindingSource.MoveNext();

        }

        private void btFin_Click(object sender, EventArgs e)
        {
            formateurBindingSource.MoveLast();
        }

        private void BtAjouter_Click(object sender, EventArgs e)
        {
            FormFormateur f = new FormFormateur();
            f.ShowDialog();
            this.Actualiser();
        }

        private void FormGestionFormateur_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void FormateurdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Formateur s = (Formateur)formateurBindingSource.Current;
                FormUpdateFormateur f = new FormUpdateFormateur();
                f.Update();
                f.ShowDialog();
                this.Actualiser();
            }
            if (e.ColumnIndex == 4)
            {
                Formateur f = (Formateur)formateurBindingSource.Current;
                new FormateurBAO().Delete(f.Id);
                this.Actualiser();

            }
        }

      
    }
}

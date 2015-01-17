using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageFilieres;
using CompetencePlus.PackageAnneeFormations;

namespace CompetencePlus.PackageGroupes
{
    public partial class FormUpdateGroupe : Form
    {
        public FormUpdateGroupe()
        {
            InitializeComponent();
        }
        int id = 0;
        public void Update(Groupe g) {
            id = g.Id;
            NomTextBox.Text = g.Nom;
            CodeTextBox.Text = g.Code;
            DescriptionTextBox.Text = g.Description;
            filiereBindingSource.DataSource = g.Filiere;
        
        }
        private void BtSave_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe();
            g.Nom = NomTextBox.Text;
            g.Id = id;
            g.Code = CodeTextBox.Text;
            g.Description = DescriptionTextBox.Text;
            g.Filiere = (Filiere)filiereBindingSource.Current;
            g.AnneeFormation = (AnneeFormation)anneeFormationBindingSource.Current;
            new GroupeBAO().Update(g);
            this.Dispose();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormUpdateGroupe_Load(object sender, EventArgs e)
        {
            filiereBindingSource.DataSource = null;
            filiereBindingSource.DataSource = new FiliereBAO().Select();

            anneeFormationBindingSource.DataSource = null;
            anneeFormationBindingSource.DataSource = new AnneeFormationDAO().Select();
        }
    }
}

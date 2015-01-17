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
    public partial class FormGroupe : Form
    {
        public FormGroupe()
        {
            InitializeComponent();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe();
            g.Nom = NomTextBox.Text;
            g.Id = 1;
            g.Code = CodeTextBox.Text;
            g.Description = DescriptionTextBox.Text;
            g.Filiere = (Filiere)filiereBindingSource.Current;
            g.AnneeFormation = (AnneeFormation)anneeFormationBindingSource.Current;
            new GroupeBAO().Add(g);
            this.Dispose();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NomTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NomTextBox.Text))
            {
                errorProviderNom.Icon = new Icon(SystemIcons.Error,1,1);
                errorProviderNom.SetError(NomTextBox,"Vous devez saisir le nom du groupe");
            }
        }

        private void FormGroupe_Load(object sender, EventArgs e)
        {
            filiereBindingSource.DataSource = null;
            filiereBindingSource.DataSource = new FiliereBAO().Select();

            anneeFormationBindingSource.DataSource = null;
            anneeFormationBindingSource.DataSource = new AnneeFormationDAO().Select();
        }

        private void NomTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (NomTextBox.Text == "")
                e.Cancel = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

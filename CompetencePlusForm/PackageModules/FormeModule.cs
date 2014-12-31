using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageModules
{
    public partial class FormeModule : Form
    {
        public FormeModule()
        {
            InitializeComponent();
        }

       
       
        private void button1_Click(object sender, EventArgs e)
        {

           
            if (nomTextBox.Text != "" && iDTextBox.Text != "" && dureeTextBox.Text != ""&& competenceTextBox.Text !="")
            {
                Module m = new Module();
                m.Nom = nomTextBox.Text;
                m.ID = int.Parse(iDTextBox.Text);
                m.Duree = int.Parse(dureeTextBox.Text);
                m.Description = descriptionTextBox.Text;
                m.Competence = competenceTextBox.Text;
                m.Presentation = presentationTextBox.Text;
                m.StrategieEnseignement = strategieEnseignementTextBox.Text;
                m.Evaluation = evaluationTextBox.Text;
                m.Apprentisage = apprentisageTextBox.Text;
                m.Equipement = equipementTextBox.Text;
                m.Materiel = materielTextBox.Text;
                new ModuleBAO().Add(m);
                this.Hide();
            }
        
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormeModule_Load(object sender, EventArgs e)
        {
          
        }

        private void dureeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void nomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void nomTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nomTextBox.Text == "")
                e.Cancel = true;
        }

        private void dureeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (dureeTextBox.Text == "")
                e.Cancel = true;
        }

        private void nomTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomTextBox .Text))
            {
                // errorProviderTitle.Icon =Properties.Resources.Error;
                errorProvidernom.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProvidernom.SetError(nomTextBox, "Vous devez saisie le nom du module");
            }
            else
            {
                errorProvidernom.Icon = Properties.Resources.Clear;
                errorProvidernom.SetError(nomTextBox, "ok");
            }
        }

        private void dureeTextBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(dureeTextBox.Text))
            {
                errorProviderduree.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProviderduree.SetError(dureeTextBox, "Vous devez saisie la duree du module");

            }
            else
            {
                errorProviderduree.Icon = Properties.Resources.Clear;
                errorProviderduree.SetError(nomTextBox, "ok");
            }
        }

        private void presentationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(char.IsDigit(e.KeyChar)!=true)
            //e.Handled = true;
        }
    }
}

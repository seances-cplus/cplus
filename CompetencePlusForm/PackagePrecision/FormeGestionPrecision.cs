using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackagePrecision;

namespace CompetencePlus.PackageModules
{
    public partial class FormeGestionPrecision : Form
    {
        public FormeGestionPrecision()
        {
            InitializeComponent();
        }
        Module m;
        public void getid(Module mos)
        {
            
            m = mos;
        }
        public void Actualiser()
        {

            precisionBindingSource.DataSource = null;
           precisionBindingSource.DataSource = new PrecisionBAO().GetallPres(m.ID);
        }

        private void FormeGestionPrecision_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Actualiser();
        }
    }
}

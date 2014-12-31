namespace CompetencePlus.PackageStagiaires
{
    partial class FormGestionInscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LastRow = new System.Windows.Forms.Button();
            this.NextRow = new System.Windows.Forms.Button();
            this.PriviousRow = new System.Windows.Forms.Button();
            this.FirstRow = new System.Windows.Forms.Button();
            this.Stagiaire = new System.Windows.Forms.GroupBox();
            this.Filiere = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stagiaireDataGridView = new System.Windows.Forms.DataGridView();
            this.stagiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirm = new System.Windows.Forms.DataGridViewImageColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Stagiaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LastRow
            // 
            this.LastRow.Location = new System.Drawing.Point(435, 222);
            this.LastRow.Name = "LastRow";
            this.LastRow.Size = new System.Drawing.Size(84, 23);
            this.LastRow.TabIndex = 11;
            this.LastRow.Text = ">>";
            this.LastRow.UseVisualStyleBackColor = true;
            this.LastRow.Click += new System.EventHandler(this.LastRow_Click);
            // 
            // NextRow
            // 
            this.NextRow.Location = new System.Drawing.Point(318, 222);
            this.NextRow.Name = "NextRow";
            this.NextRow.Size = new System.Drawing.Size(84, 23);
            this.NextRow.TabIndex = 10;
            this.NextRow.Text = ">";
            this.NextRow.UseVisualStyleBackColor = true;
            this.NextRow.Click += new System.EventHandler(this.NextRow_Click);
            // 
            // PriviousRow
            // 
            this.PriviousRow.Location = new System.Drawing.Point(199, 222);
            this.PriviousRow.Name = "PriviousRow";
            this.PriviousRow.Size = new System.Drawing.Size(84, 23);
            this.PriviousRow.TabIndex = 9;
            this.PriviousRow.Text = "<";
            this.PriviousRow.UseVisualStyleBackColor = true;
            this.PriviousRow.Click += new System.EventHandler(this.PriviousRow_Click);
            // 
            // FirstRow
            // 
            this.FirstRow.Location = new System.Drawing.Point(90, 222);
            this.FirstRow.Name = "FirstRow";
            this.FirstRow.Size = new System.Drawing.Size(84, 23);
            this.FirstRow.TabIndex = 8;
            this.FirstRow.Text = "<<";
            this.FirstRow.UseVisualStyleBackColor = true;
            this.FirstRow.Click += new System.EventHandler(this.FirstRow_Click);
            // 
            // Stagiaire
            // 
            this.Stagiaire.Controls.Add(this.Filiere);
            this.Stagiaire.Controls.Add(this.prenom);
            this.Stagiaire.Controls.Add(this.Nom);
            this.Stagiaire.Controls.Add(this.pictureBox1);
            this.Stagiaire.Location = new System.Drawing.Point(55, 12);
            this.Stagiaire.Name = "Stagiaire";
            this.Stagiaire.Size = new System.Drawing.Size(514, 192);
            this.Stagiaire.TabIndex = 7;
            this.Stagiaire.TabStop = false;
            this.Stagiaire.Text = "Stagiaire";
            // 
            // Filiere
            // 
            this.Filiere.AutoSize = true;
            this.Filiere.Location = new System.Drawing.Point(187, 119);
            this.Filiere.Name = "Filiere";
            this.Filiere.Size = new System.Drawing.Size(34, 13);
            this.Filiere.TabIndex = 3;
            this.Filiere.Text = "Filiere";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(187, 85);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(43, 13);
            this.prenom.TabIndex = 2;
            this.prenom.Text = "Prenom";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(187, 48);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stagiaireDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(45, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 255);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tableau stagiaires";
            // 
            // stagiaireDataGridView
            // 
            this.stagiaireDataGridView.AutoGenerateColumns = false;
            this.stagiaireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stagiaireDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.Confirm,
            this.Update,
            this.Delete});
            this.stagiaireDataGridView.DataSource = this.stagiaireBindingSource;
            this.stagiaireDataGridView.Location = new System.Drawing.Point(9, 19);
            this.stagiaireDataGridView.Name = "stagiaireDataGridView";
            this.stagiaireDataGridView.Size = new System.Drawing.Size(493, 220);
            this.stagiaireDataGridView.TabIndex = 0;
            this.stagiaireDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stagiaireDataGridView_CellClick);
            // 
            // stagiaireBindingSource
            // 
            this.stagiaireBindingSource.DataSource = typeof(CompetencePlus.PackageStagiaires.Stagiaire);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::CompetencePlus.Properties.Resources.confirm;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::CompetencePlus.Properties.Resources.Update;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::CompetencePlus.Properties.Resources.Delete;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Filiere";
            this.dataGridViewTextBoxColumn1.HeaderText = "Filiere";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Confirm
            // 
            this.Confirm.HeaderText = "";
            this.Confirm.Image = global::CompetencePlus.Properties.Resources.confirm;
            this.Confirm.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Confirm.Name = "Confirm";
            this.Confirm.Width = 50;
            // 
            // Update
            // 
            this.Update.HeaderText = "";
            this.Update.Image = global::CompetencePlus.Properties.Resources.Update;
            this.Update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Update.Name = "Update";
            this.Update.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::CompetencePlus.Properties.Resources.Delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // FormGestionInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 532);
            this.Controls.Add(this.LastRow);
            this.Controls.Add(this.NextRow);
            this.Controls.Add(this.PriviousRow);
            this.Controls.Add(this.FirstRow);
            this.Controls.Add(this.Stagiaire);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestionInscription";
            this.Text = "FormGestionInscription";
            this.Load += new System.EventHandler(this.FormGestionInscription_Load);
            this.Stagiaire.ResumeLayout(false);
            this.Stagiaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LastRow;
        private System.Windows.Forms.Button NextRow;
        private System.Windows.Forms.Button PriviousRow;
        private System.Windows.Forms.Button FirstRow;
        private System.Windows.Forms.GroupBox Stagiaire;
        private System.Windows.Forms.Label Filiere;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView stagiaireDataGridView;
        private System.Windows.Forms.BindingSource stagiaireBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Confirm;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
﻿namespace CompetencePlus.PackageGroupes
{
    partial class FormGroupe
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
            this.BtCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.filiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.BtSave = new System.Windows.Forms.Button();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.AnneeComboBox = new System.Windows.Forms.ComboBox();
            this.AnneeFormation = new System.Windows.Forms.Label();
            this.anneeFormationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeFormationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCancel
            // 
            this.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtCancel.Location = new System.Drawing.Point(216, 370);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(102, 23);
            this.BtCancel.TabIndex = 10;
            this.BtCancel.Text = "Annuler";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnneeComboBox);
            this.groupBox1.Controls.Add(this.AnneeFormation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.CodeTextBox);
            this.groupBox1.Controls.Add(this.NomTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 341);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groupe";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filiere";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.filiereBindingSource;
            this.comboBox1.DisplayMember = "Titre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Id";
            // 
            // filiereBindingSource
            // 
            this.filiereBindingSource.DataSource = typeof(CompetencePlus.PackageFilieres.Filiere);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(109, 196);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(372, 129);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.AcceptsReturn = true;
            this.CodeTextBox.Location = new System.Drawing.Point(109, 58);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(163, 20);
            this.CodeTextBox.TabIndex = 1;
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(109, 19);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(372, 20);
            this.NomTextBox.TabIndex = 0;
            this.NomTextBox.Leave += new System.EventHandler(this.NomTextBox_Leave);
            this.NomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NomTextBox_Validating);
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(108, 370);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(102, 23);
            this.BtSave.TabIndex = 9;
            this.BtSave.Text = "Enregistrer";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // AnneeComboBox
            // 
            this.AnneeComboBox.DataSource = this.anneeFormationBindingSource;
            this.AnneeComboBox.DisplayMember = "Title";
            this.AnneeComboBox.FormattingEnabled = true;
            this.AnneeComboBox.Location = new System.Drawing.Point(109, 149);
            this.AnneeComboBox.Name = "AnneeComboBox";
            this.AnneeComboBox.Size = new System.Drawing.Size(163, 21);
            this.AnneeComboBox.TabIndex = 11;
            this.AnneeComboBox.ValueMember = "Id";
            // 
            // AnneeFormation
            // 
            this.AnneeFormation.AutoSize = true;
            this.AnneeFormation.Location = new System.Drawing.Point(0, 149);
            this.AnneeFormation.Name = "AnneeFormation";
            this.AnneeFormation.Size = new System.Drawing.Size(105, 13);
            this.AnneeFormation.TabIndex = 10;
            this.AnneeFormation.Text = "Annee de formation :";
            // 
            // anneeFormationBindingSource
            // 
            this.anneeFormationBindingSource.DataSource = typeof(CompetencePlus.PackageAnneeFormations.AnneeFormation);
            // 
            // FormGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 405);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtSave);
            this.Name = "FormGroupe";
            this.Text = "FormGroupe";
            this.Load += new System.EventHandler(this.FormGroupe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeFormationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.BindingSource filiereBindingSource;
        private System.Windows.Forms.ComboBox AnneeComboBox;
        private System.Windows.Forms.BindingSource anneeFormationBindingSource;
        private System.Windows.Forms.Label AnneeFormation;
    }
}
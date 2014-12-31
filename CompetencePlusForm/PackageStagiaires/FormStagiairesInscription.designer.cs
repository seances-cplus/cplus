namespace CompetencePlus.PackageStagiaires
{
    partial class FormStagiairesInscription
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
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label Filierelabel;
            System.Windows.Forms.Label Cinlabel;
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label sexeLabel;
            this.BtValide = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FilierecomboBox = new System.Windows.Forms.ComboBox();
            this.filiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SexeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.CinTextBox = new System.Windows.Forms.TextBox();
            this.dateNaissanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.PrenomTextBox = new System.Windows.Forms.TextBox();
            this.sexeRadioButton = new System.Windows.Forms.RadioButton();
            this.BtProfilImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            adresseLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            Filierelabel = new System.Windows.Forms.Label();
            Cinlabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(28, 115);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(48, 13);
            adresseLabel.TabIndex = 2;
            adresseLabel.Text = "Adresse:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(28, 33);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(28, 75);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 16;
            telephoneLabel.Text = "Telephone:";
            // 
            // Filierelabel
            // 
            Filierelabel.AutoSize = true;
            Filierelabel.Location = new System.Drawing.Point(28, 46);
            Filierelabel.Name = "Filierelabel";
            Filierelabel.Size = new System.Drawing.Size(40, 13);
            Filierelabel.TabIndex = 2;
            Filierelabel.Text = "Filiere :";
            // 
            // Cinlabel
            // 
            Cinlabel.AutoSize = true;
            Cinlabel.Location = new System.Drawing.Point(35, 280);
            Cinlabel.Name = "Cinlabel";
            Cinlabel.Size = new System.Drawing.Size(25, 13);
            Cinlabel.TabIndex = 4;
            Cinlabel.Text = "Cin:";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(35, 201);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(86, 13);
            dateNaissanceLabel.TabIndex = 6;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(35, 124);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 10;
            nomLabel.Text = "Nom:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 163);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 13);
            label2.TabIndex = 12;
            label2.Text = "Prenom:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(35, 244);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 14;
            sexeLabel.Text = "Sexe:";
            // 
            // BtValide
            // 
            this.BtValide.Location = new System.Drawing.Point(312, 393);
            this.BtValide.Name = "BtValide";
            this.BtValide.Size = new System.Drawing.Size(86, 24);
            this.BtValide.TabIndex = 6;
            this.BtValide.Text = "Validé";
            this.BtValide.UseVisualStyleBackColor = true;
            this.BtValide.Click += new System.EventHandler(this.BtValide_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(adresseLabel);
            this.groupBox3.Controls.Add(this.emailTextBox);
            this.groupBox3.Controls.Add(this.adresseTextBox);
            this.groupBox3.Controls.Add(emailLabel);
            this.groupBox3.Controls.Add(this.telephoneTextBox);
            this.groupBox3.Controls.Add(telephoneLabel);
            this.groupBox3.Location = new System.Drawing.Point(370, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 197);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cordonnée";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(120, 30);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(170, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.Location = new System.Drawing.Point(120, 112);
            this.adresseTextBox.Multiline = true;
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(231, 79);
            this.adresseTextBox.TabIndex = 3;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(120, 72);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(170, 20);
            this.telephoneTextBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(Filierelabel);
            this.groupBox2.Controls.Add(this.FilierecomboBox);
            this.groupBox2.Location = new System.Drawing.Point(370, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filiere";
            // 
            // FilierecomboBox
            // 
            this.FilierecomboBox.DataSource = this.filiereBindingSource;
            this.FilierecomboBox.DisplayMember = "Titre";
            this.FilierecomboBox.FormattingEnabled = true;
            this.FilierecomboBox.Location = new System.Drawing.Point(120, 43);
            this.FilierecomboBox.Name = "FilierecomboBox";
            this.FilierecomboBox.Size = new System.Drawing.Size(154, 21);
            this.FilierecomboBox.TabIndex = 3;
            this.FilierecomboBox.ValueMember = "Id";
            // 
            // filiereBindingSource
            // 
            this.filiereBindingSource.DataSource = typeof(CompetencePlus.PackageFilieres.Filiere);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SexeRadioButton2);
            this.groupBox1.Controls.Add(Cinlabel);
            this.groupBox1.Controls.Add(this.CinTextBox);
            this.groupBox1.Controls.Add(dateNaissanceLabel);
            this.groupBox1.Controls.Add(this.dateNaissanceDateTimePicker);
            this.groupBox1.Controls.Add(nomLabel);
            this.groupBox1.Controls.Add(this.nomTextBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.PrenomTextBox);
            this.groupBox1.Controls.Add(sexeLabel);
            this.groupBox1.Controls.Add(this.sexeRadioButton);
            this.groupBox1.Controls.Add(this.BtProfilImage);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 318);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information générale";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SexeRadioButton2
            // 
            this.SexeRadioButton2.Location = new System.Drawing.Point(236, 238);
            this.SexeRadioButton2.Name = "SexeRadioButton2";
            this.SexeRadioButton2.Size = new System.Drawing.Size(78, 24);
            this.SexeRadioButton2.TabIndex = 16;
            this.SexeRadioButton2.TabStop = true;
            this.SexeRadioButton2.Text = "Femelle";
            this.SexeRadioButton2.UseVisualStyleBackColor = true;
            // 
            // CinTextBox
            // 
            this.CinTextBox.Location = new System.Drawing.Point(127, 277);
            this.CinTextBox.Name = "CinTextBox";
            this.CinTextBox.Size = new System.Drawing.Size(200, 20);
            this.CinTextBox.TabIndex = 5;
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(127, 197);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateNaissanceDateTimePicker.TabIndex = 7;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(127, 121);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomTextBox.TabIndex = 11;
            // 
            // PrenomTextBox
            // 
            this.PrenomTextBox.Location = new System.Drawing.Point(127, 160);
            this.PrenomTextBox.Name = "PrenomTextBox";
            this.PrenomTextBox.Size = new System.Drawing.Size(200, 20);
            this.PrenomTextBox.TabIndex = 13;
            // 
            // sexeRadioButton
            // 
            this.sexeRadioButton.Location = new System.Drawing.Point(127, 238);
            this.sexeRadioButton.Name = "sexeRadioButton";
            this.sexeRadioButton.Size = new System.Drawing.Size(54, 24);
            this.sexeRadioButton.TabIndex = 15;
            this.sexeRadioButton.TabStop = true;
            this.sexeRadioButton.Text = "Male";
            this.sexeRadioButton.UseVisualStyleBackColor = true;
            // 
            // BtProfilImage
            // 
            this.BtProfilImage.Location = new System.Drawing.Point(141, 60);
            this.BtProfilImage.Name = "BtProfilImage";
            this.BtProfilImage.Size = new System.Drawing.Size(173, 27);
            this.BtProfilImage.TabIndex = 1;
            this.BtProfilImage.Text = "Choisir une photo";
            this.BtProfilImage.UseVisualStyleBackColor = true;
            this.BtProfilImage.Click += new System.EventHandler(this.BtProfilImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CompetencePlus.Properties.Resources.Profile;
            this.pictureBox1.Location = new System.Drawing.Point(15, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // FormStagiairesInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 434);
            this.Controls.Add(this.BtValide);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormStagiairesInscription";
            this.Text = "FormStagiairesInscription";
            this.Load += new System.EventHandler(this.FormStagiairesInscription_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtValide;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox FilierecomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SexeRadioButton2;
        private System.Windows.Forms.TextBox CinTextBox;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox PrenomTextBox;
        private System.Windows.Forms.RadioButton sexeRadioButton;
        private System.Windows.Forms.Button BtProfilImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.BindingSource filiereBindingSource;
    }
}

namespace Gestion_Clients
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Identity = new System.Windows.Forms.ComboBox();
            this.Adresse = new System.Windows.Forms.ComboBox();
            this.Prenom = new System.Windows.Forms.ComboBox();
            this.nom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Suprimer = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ville = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Identity
            // 
            this.Identity.FormattingEnabled = true;
            this.Identity.Location = new System.Drawing.Point(145, 35);
            this.Identity.Name = "Identity";
            this.Identity.Size = new System.Drawing.Size(121, 24);
            this.Identity.TabIndex = 0;
            // 
            // Adresse
            // 
            this.Adresse.FormattingEnabled = true;
            this.Adresse.Location = new System.Drawing.Point(145, 146);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(121, 24);
            this.Adresse.TabIndex = 1;
            // 
            // Prenom
            // 
            this.Prenom.FormattingEnabled = true;
            this.Prenom.Location = new System.Drawing.Point(145, 116);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(121, 24);
            this.Prenom.TabIndex = 2;
            // 
            // nom
            // 
            this.nom.FormattingEnabled = true;
            this.nom.Location = new System.Drawing.Point(145, 74);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(121, 24);
            this.nom.TabIndex = 3;
            this.nom.SelectedIndexChanged += new System.EventHandler(this.nom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ville";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Suprimer
            // 
            this.Suprimer.Location = new System.Drawing.Point(436, 77);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(75, 23);
            this.Suprimer.TabIndex = 9;
            this.Suprimer.Text = "Supprimer";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(436, 119);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(75, 23);
            this.Modify.TabIndex = 10;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 173);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ville
            // 
            this.Ville.FormattingEnabled = true;
            this.Ville.Location = new System.Drawing.Point(145, 185);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(121, 24);
            this.Ville.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adresse";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(750, 398);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Identity);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Identity;
        private System.Windows.Forms.ComboBox Adresse;
        private System.Windows.Forms.ComboBox Prenom;
        private System.Windows.Forms.ComboBox nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Ville;
        private System.Windows.Forms.Label label6;
    }
}


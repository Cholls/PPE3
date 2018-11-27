namespace PPE3_GSB_WF
{
    partial class Form_Visiteurs
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
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.grid_Visiteurs = new System.Windows.Forms.DataGridView();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.cb_Medecins = new System.Windows.Forms.ComboBox();
            this.lbl_lstVisiteurs = new System.Windows.Forms.Label();
            this.lbl_choixVisiteurs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Visiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(529, 353);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(104, 39);
            this.btn_Quitter.TabIndex = 0;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // grid_Visiteurs
            // 
            this.grid_Visiteurs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_Visiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Visiteurs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grid_Visiteurs.Location = new System.Drawing.Point(49, 47);
            this.grid_Visiteurs.Name = "grid_Visiteurs";
            this.grid_Visiteurs.Size = new System.Drawing.Size(289, 337);
            this.grid_Visiteurs.TabIndex = 1;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Location = new System.Drawing.Point(155, 393);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 2;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.Location = new System.Drawing.Point(490, 206);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(82, 23);
            this.btn_Modifier.TabIndex = 3;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supprimer.Location = new System.Drawing.Point(590, 206);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(82, 23);
            this.btn_Supprimer.TabIndex = 4;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // cb_Medecins
            // 
            this.cb_Medecins.FormattingEnabled = true;
            this.cb_Medecins.Location = new System.Drawing.Point(486, 164);
            this.cb_Medecins.Name = "cb_Medecins";
            this.cb_Medecins.Size = new System.Drawing.Size(190, 21);
            this.cb_Medecins.TabIndex = 5;
            // 
            // lbl_lstVisiteurs
            // 
            this.lbl_lstVisiteurs.AutoSize = true;
            this.lbl_lstVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstVisiteurs.Location = new System.Drawing.Point(95, 17);
            this.lbl_lstVisiteurs.Name = "lbl_lstVisiteurs";
            this.lbl_lstVisiteurs.Size = new System.Drawing.Size(204, 25);
            this.lbl_lstVisiteurs.TabIndex = 6;
            this.lbl_lstVisiteurs.Text = "Liste des visiteurs";
            // 
            // lbl_choixVisiteurs
            // 
            this.lbl_choixVisiteurs.AutoSize = true;
            this.lbl_choixVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choixVisiteurs.Location = new System.Drawing.Point(502, 135);
            this.lbl_choixVisiteurs.Name = "lbl_choixVisiteurs";
            this.lbl_choixVisiteurs.Size = new System.Drawing.Size(153, 16);
            this.lbl_choixVisiteurs.TabIndex = 7;
            this.lbl_choixVisiteurs.Text = "Séléctionnez un visiteur :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(380, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 434);
            this.panel1.TabIndex = 8;
            // 
            // Form_Visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_choixVisiteurs);
            this.Controls.Add(this.lbl_lstVisiteurs);
            this.Controls.Add(this.cb_Medecins);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.grid_Visiteurs);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Visiteurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visiteurs";
            this.Load += new System.EventHandler(this.Form_Visiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Visiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.DataGridView grid_Visiteurs;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.ComboBox cb_Medecins;
        private System.Windows.Forms.Label lbl_lstVisiteurs;
        private System.Windows.Forms.Label lbl_choixVisiteurs;
        private System.Windows.Forms.Panel panel1;
    }
}
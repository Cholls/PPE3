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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_lstVisiteurs = new System.Windows.Forms.Label();
            this.lbl_choixVisiteurs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Visiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(493, 358);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(104, 39);
            this.btn_Quitter.TabIndex = 0;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // grid_Visiteurs
            // 
            this.grid_Visiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Visiteurs.Location = new System.Drawing.Point(30, 47);
            this.grid_Visiteurs.Name = "grid_Visiteurs";
            this.grid_Visiteurs.Size = new System.Drawing.Size(289, 337);
            this.grid_Visiteurs.TabIndex = 1;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(137, 390);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 2;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(455, 227);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_Modifier.TabIndex = 3;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(563, 227);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 4;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(484, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lbl_lstVisiteurs
            // 
            this.lbl_lstVisiteurs.AutoSize = true;
            this.lbl_lstVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstVisiteurs.Location = new System.Drawing.Point(75, 19);
            this.lbl_lstVisiteurs.Name = "lbl_lstVisiteurs";
            this.lbl_lstVisiteurs.Size = new System.Drawing.Size(204, 25);
            this.lbl_lstVisiteurs.TabIndex = 6;
            this.lbl_lstVisiteurs.Text = "Liste des visiteurs";
            // 
            // lbl_choixVisiteurs
            // 
            this.lbl_choixVisiteurs.AutoSize = true;
            this.lbl_choixVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choixVisiteurs.Location = new System.Drawing.Point(471, 156);
            this.lbl_choixVisiteurs.Name = "lbl_choixVisiteurs";
            this.lbl_choixVisiteurs.Size = new System.Drawing.Size(153, 16);
            this.lbl_choixVisiteurs.TabIndex = 7;
            this.lbl_choixVisiteurs.Text = "Séléctionnez un visiteur :";
            // 
            // Form_Visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 425);
            this.Controls.Add(this.lbl_choixVisiteurs);
            this.Controls.Add(this.lbl_lstVisiteurs);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_lstVisiteurs;
        private System.Windows.Forms.Label lbl_choixVisiteurs;
    }
}
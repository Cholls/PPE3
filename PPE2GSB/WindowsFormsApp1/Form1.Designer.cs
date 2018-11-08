namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lesMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesMédecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesMédicamentsToolStripMenuItem,
            this.lesVisiteursToolStripMenuItem,
            this.lesMédecinsToolStripMenuItem,
            this.lesRapportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lesMédicamentsToolStripMenuItem
            // 
            this.lesMédicamentsToolStripMenuItem.Name = "lesMédicamentsToolStripMenuItem";
            this.lesMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.lesMédicamentsToolStripMenuItem.Text = "Les médicaments";
            this.lesMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.lesMédicamentsToolStripMenuItem_Click);
            // 
            // lesVisiteursToolStripMenuItem
            // 
            this.lesVisiteursToolStripMenuItem.Name = "lesVisiteursToolStripMenuItem";
            this.lesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.lesVisiteursToolStripMenuItem.Text = "Les visiteurs";
            // 
            // lesMédecinsToolStripMenuItem
            // 
            this.lesMédecinsToolStripMenuItem.Name = "lesMédecinsToolStripMenuItem";
            this.lesMédecinsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.lesMédecinsToolStripMenuItem.Text = "Les médecins";
            // 
            // lesRapportsToolStripMenuItem
            // 
            this.lesRapportsToolStripMenuItem.Name = "lesRapportsToolStripMenuItem";
            this.lesRapportsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.lesRapportsToolStripMenuItem.Text = "Les rapports";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 31);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(766, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lesMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesMédecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesRapportsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}


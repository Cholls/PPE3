﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_GSB_WF
{
    public partial class Form_Accueil : Form
    {
        public Form_Accueil()
        {
            InitializeComponent();
        }

        private void Form_Accueil_Load(object sender, EventArgs e)
        {
            Form_Connexion seConnecte = new Form_Connexion();
            seConnecte.ShowDialog();
        }
    }
}

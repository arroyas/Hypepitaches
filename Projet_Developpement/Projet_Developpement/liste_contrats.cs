﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_Developpement
{
    public partial class liste_contrats : Form
    {


        private GRHProjectEntities1 bd;

        public liste_contrats(GRHProjectEntities1 p_bd)
        {

            InitializeComponent();

            bd = p_bd;
            bs.DataSource = bd.CONTRAT;

        }
    }
}

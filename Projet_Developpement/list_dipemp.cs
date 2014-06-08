using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_Developpement
{
    public partial class list_dipemp : Form
    {
        private GRHProjectEntities1 bd;
        public list_dipemp(GRHProjectEntities1 p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            bs_dip.DataSource = bd.DIPLOME;
        }

        private void dIPLOMEListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_autres_Click(object sender, EventArgs e)
        {
            if (bs_emp.Current != null)
            {
                if (lb_dipPoss.SelectedIndex != -1)
                {
                    EMPLOYE leEmploye = (EMPLOYE)bs_emp.Current;
                    DIPLOME leDiplome = (DIPLOME)lb_dipPoss.SelectedItem;
                    leEmploye.LesDiplomes.Remove(leDiplome);
                    bs_dipemp.Add(leDiplome);
                }
            }
        }

        private void btn_poss_Click(object sender, EventArgs e)
        {
            if (bs_emp.Current != null)
            {
                if (lb_autreDip.SelectedIndex != -1)
                {
                    EMPLOYE leEmploye = (EMPLOYE)bs_emp.Current;
                    DIPLOME leDiplome = (DIPLOME)lb_autreDip.SelectedItem;
                    leEmploye.LesDiplomes.Add(leDiplome);
                    bs_dipemp.Remove(leDiplome);
                }
            }
        }
    }
}

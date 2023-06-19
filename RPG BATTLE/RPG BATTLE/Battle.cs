using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_BATTLE
{
    public partial class Battle : Form
    {
        public RPG.Character player;
        Random rnd = new Random();
        
        


        public Battle()
        {
            InitializeComponent();
        }


        public void loadData()
        {
            txtPlayerHealth.Text = player.health.ToString();
            txtEnemyHealth.Text = player.health.ToString();            
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

            int attackDamage = rnd.Next(0, player.damage);
            lblInfo.Text = "Attacked for " + attackDamage + " damage!";
            lblInfo.Visible = true;

            txtEnemyHealth.Text = Convert.ToString(int.Parse(txtEnemyHealth.Text) - attackDamage);
        }

    }
}

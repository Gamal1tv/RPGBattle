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
            txtEnemyHealth.Text = 100.ToString();            
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

            int attackDamage = rnd.Next(1, player.damage);
            if (int.Parse(txtEnemyHealth.Text) - attackDamage < 0)
            {
                txtEnemyHealth.Text = "0";
                lblInfo.Text = "VICTORY!";
                lblInfo.Visible = true;
                btnContinue.Visible = true;
                btnExit.Visible = true;
                btnAttack.Visible = false;
                btnDefend.Visible = false;
                btnHeal.Visible = false;
            }
            else
            {
                lblInfo.Text = "Attacked for " + attackDamage + " damage!";
                lblInfo.Visible = true;
                txtEnemyHealth.Text = Convert.ToString(int.Parse(txtEnemyHealth.Text) - attackDamage);
                Task.Delay(1500).Wait();
                int enemyDamage = rnd.Next(1, 50);

                if (int.Parse(txtPlayerHealth.Text) - enemyDamage < 0)
                {
                    txtPlayerHealth.Text = "0";
                    lblInfo.Text = "You Died";
                    lblInfo.Visible = true;
                    btnContinue.Visible = true;
                    btnExit.Visible = true;
                    btnAttack.Visible = false;
                    btnDefend.Visible = false;
                    btnHeal.Visible = false;
                }
                else
                {
                    lblInfo.Text = "The enemy attacked for " + enemyDamage + " damage!";
                    txtPlayerHealth.Text = Convert.ToString(int.Parse(txtPlayerHealth.Text) - enemyDamage);
                }
                
            }
            
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            int healthHealed = rnd.Next(1, 50);
            lblInfo.Text = "You healed for " + healthHealed;
            lblInfo.Visible = true;
            txtPlayerHealth.Text = Convert.ToString(int.Parse(txtPlayerHealth.Text) + healthHealed);

            Task.Delay(1500).Wait();
            int enemyDamage = rnd.Next(1, 50);
            if (int.Parse(txtPlayerHealth.Text) - enemyDamage < 0)
            {
                txtPlayerHealth.Text = "0";
                lblInfo.Text = "You Died";
                lblInfo.Visible = true;
                btnContinue.Visible = true;
                btnExit.Visible = true;
                btnAttack.Visible = false;
                btnDefend.Visible = false;
                btnHeal.Visible = false;
            }
            else
            {
                lblInfo.Text = "The enemy attacked for " + enemyDamage + " damage!";
                txtPlayerHealth.Text = Convert.ToString(int.Parse(txtPlayerHealth.Text) - enemyDamage);
            }
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            int enemyDamage = rnd.Next(1, 50);
            lblInfo.Text = "The enemy tried to attack you for " + enemyDamage + " damage, but you blocked it!";
            lblInfo.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

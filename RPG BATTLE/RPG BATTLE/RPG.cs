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
    public partial class RPG : Form
    {

        public class Character
        {
            public int health;
            public int damage;
        }

        public RPG()
        {
            InitializeComponent();
        }


        private void cbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbCharacters.Text == "Warrior")
            {
                Battle Battle = new Battle();

                Character warrior = new Character();
                warrior.health = 100;
                warrior.damage = 50;

                Battle.player = warrior;

                Battle.loadData();
                Battle.ShowDialog();
            }
            else if (cbCharacters.Text == "Assassin")
            {
                Battle Battle = new Battle();

                Character assassin = new Character();
                assassin.health = 75;
                assassin.damage = 65;

                Battle.player = assassin;

                Battle.loadData();
                Battle.ShowDialog();
            }
            else if (cbCharacters.Text == "Tank")
            {
                Battle Battle = new Battle();

                Character tank = new Character();
                tank.health = 125;
                tank.damage = 35;

                Battle.player = tank;

                Battle.loadData();
                Battle.ShowDialog();
            }

        }
    }
}

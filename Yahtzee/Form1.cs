using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class dice : Form
    {
        Random rngeesus = new Random();
        Image[] diceImg;
        int[]diceNum;

        public dice()
        {
            InitializeComponent();
        }

        private void dice_Load(object sender, EventArgs e)
        {
            diceImg = new Image[8];
            diceImg[0] = Properties.Resources.rollDice;
            diceImg[1] = Properties.Resources.dice1;
            diceImg[2] = Properties.Resources.dice2;
            diceImg[3] = Properties.Resources.dice3;
            diceImg[4] = Properties.Resources.dice4;
            diceImg[5] = Properties.Resources.dice5;
            diceImg[6] = Properties.Resources.dice6;
            diceImg[7] = Properties.Resources.dice1_6;

            diceNum = new int[5] { 0, 0, 0, 0, 0 };
            rngeesus = new Random();

        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            Roll();
        }
        private void Roll()
        {
            for (int i = 0; i < diceNum.Length; i++)
                diceNum[i] = rngeesus.Next(1, 6);
            dice1.Image = diceImg[diceNum[0]];
            dice2.Image = diceImg[diceNum[1]];
            dice3.Image = diceImg[diceNum[2]];
            dice4.Image = diceImg[diceNum[3]];
            dice5.Image = diceImg[diceNum[4]];

        }
    }
}

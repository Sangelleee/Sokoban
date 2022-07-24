using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label[] boxes = new Label[3];
        Label[] bases = new Label[3];

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Box.ChecWin(boxes, bases))
            {
                Sound.MoveSoundPlay();
                MovePlayer(e);
            }
            else
            {
                Sound.VictorySoundPlay();
            }

        }

        private void MovePlayer(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && player.Top > 30)
            {
                Box.UpBoxMove(player, boxes); player.Top -= player.Height;
            }
            else if (e.KeyCode == Keys.Down && player.Top < Height - 2 * player.Height)
            {
                Box.DownBoxMove(player, boxes); player.Top += player.Height;
            }
            else if (e.KeyCode == Keys.Left && player.Left > 30)
            {
                Box.LeftBoxMove(player, boxes); player.Left -= player.Width;
            }
            else if (e.KeyCode == Keys.Right && player.Left < Width - 2 * player.Width)
            {
                Box.RightBoxMove(player, boxes); player.Left += player.Width;
            }
        }

        private void включитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sound.MoveSoundPlayON();
            label1.Text = "Звук включен";
        }

        private void выключитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sound.MoveSoundPlayOFF();
            label1.Text = "Звук выключен";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boxes[0] = box1;
            boxes[1] = box2;
            boxes[2] = box3;
            bases[0] = base1;
            bases[1] = base2;
            bases[2] = base3;
        }
    }
}

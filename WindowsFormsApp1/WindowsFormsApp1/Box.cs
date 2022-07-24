using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Box
    {
        public static void RightBoxMove(Label player, Label[] box)
        {
            for (int i = 0; i < box.Length; i++)
            {
                if (player.Location.X == box[i].Location.X - player.Width &&
                    player.Location.Y == box[i].Location.Y)
                    box[i].Left += box[i].Width;
            }
        }

        internal static bool ChecWin(Label[] box, Label[] bases)
        {
            for (int i = 0; i < bases.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < box.Length; j++)
                {
                    if (bases[i].Bounds.IntersectsWith(box[j].Bounds))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    return false;
                }
            }
            return true;
        }

        public static void LeftBoxMove(Label player, Label[] box)
        {
            for (int i = 0; i < box.Length; i++)
            {
                if (player.Location.X == box[i].Location.X + player.Width &&
                    player.Location.Y == box[i].Location.Y)
                    box[i].Left -= box[i].Width;
            }
        }
        public static void DownBoxMove(Label player, Label[] box)
        {
            for (int i = 0; i < box.Length; i++)
            {
                if (player.Location.Y == box[i].Location.Y - player.Height &&
                    player.Location.X == box[i].Location.X)
                    box[i].Top += box[i].Height;
            }
        }
        public static void UpBoxMove(Label player, Label[] box)
        {
            for (int i = 0; i < box.Length; i++)
            {
                if (player.Location.Y == box[i].Location.Y + player.Height &&
                    player.Location.X == box[i].Location.X)
                    box[i].Top -= box[i].Height;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    internal class Ball
    {
        public int vY { get; set; }
        public int vX { get; set; }
        public Ball(string ballDir)
        {
            ballDir = ballDir.Trim(new char[] { '\0' });

            if (ballDir.StartsWith("{") && ballDir.EndsWith("}"))
            {
                ballDir = ballDir.Trim(new Char[] { ' ', '{', '}' });
                MessageBox.Show(ballDir);

                string[] ballDirSplit = ballDir.Split('|'); // 0=x, 1=y
                MessageBox.Show(ballDirSplit[1] + ", " + ballDirSplit[2]);
                vX = int.Parse(ballDirSplit[1]);
                vY = int.Parse(ballDirSplit[2]);
            }
        }
    }
}

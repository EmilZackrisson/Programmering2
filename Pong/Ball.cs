using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string[] data = ballDir.Split('|'); // 0=x, 1=y

                vX = int.Parse(data[0]);
                vY = int.Parse(data[1]);
            }
        }
    }
}

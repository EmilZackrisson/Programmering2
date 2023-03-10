using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Server
{
    internal class Ball
    {
        public string randomizeDirection()
        {
            Random random = new Random();
            int ballXDir = random.Next(1, 3);
            int ballYDir = random.Next(1, 3);
            int vX, vY;

            if (ballXDir > 1)
            {
                if (ballYDir > 1)
                {
                    vX = 3;
                    vY = 3;
                }
                else
                {
                    vX = 3;
                    vY = -3;
                }
            }
            else
            {
                if (ballYDir > 1)
                {
                    vX = -3;
                    vY = 3;
                }
                else
                {
                    vX = -3;
                    vY = 3;
                }
            }


            return vX + "|" + vY;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server
{
    internal class Player
    {
        public Point Location { get; set; }
        public string Side { get; set; }
        public int Point { get; set; }

        public Player(Point location, string side)
        {
            Location = location;
            Side = side;
        }

        public void AddPoint()
        {
            Point++;
        }

        public void SetPlayer(string playerData)
        {
            playerData = playerData.Trim(new char[] { '\0' });
            if (playerData.StartsWith("{") && playerData.EndsWith("}"))
            {
                playerData = playerData.Trim(new Char[] { ' ', '{', '}' });
                string[] data = playerData.Split('|'); // 0=side, 1=location, 2=points
                Side = data[0];

                // Gets and sets location
                string[] coords = data[1].Split(',');
                Location = new Point(int.Parse(coords[0].Replace("X=", "").Replace("{", "")), int.Parse(coords[1].Replace("Y=", "").Replace("}", "")));
            }
            else
            {
                //MessageBox.Show("SetPlayer fick fel indata:\n" + playerData);
            }
        }

        public override string ToString()
        {
            return "{" + Side + "|" + Location.ToString() + "|" + Point + "}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
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
            string[] data = playerData.Split(','); // 0=side, 1=location, 2=points
            Side = data[0];

            // Gets and sets location
            string[] coords = data[1].Split(',');
            coords[0] = coords[0].Remove(0, 3);
            coords[1] = coords[1].Remove(0, 2);
            coords[1] = coords[1].Remove(coords.Length - 1, 1);
            Location = new Point(int.Parse(coords[0]), int.Parse(coords[1]));

            // Gets and sets points
            Point = int.Parse(data[2]);
        }

        public override string ToString()
        {
            return Side + "," + Location + "," + Point;
        }
    }
}

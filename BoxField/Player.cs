using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BoxField
{
    class Player
    {
     public int x, y, size, speed;

        public Player(int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }
        public void move(Player p, string direction)
        {
            if (direction == "left")
            {
                p.x -= p.speed;
            }
            else
            {
                p.x += p.speed;
            }
        }
        public bool collision (Player p, Cube c)
        {
            Rectangle pRec = new Rectangle(p.x, p.y, p.size, p.size);
            Rectangle cRec = new Rectangle(c.x, c.y, c.size, c.size);
            if (pRec.IntersectsWith(cRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

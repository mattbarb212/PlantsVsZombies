﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVsZombies
{
    class Zombies
    {
        public int x, y, size, speed;

        public Zombies(int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }
        public void Move()
        {
            x -= speed;
        }
        //public bool Collision(Box b)
        //{
        //    Rectangle thisRec = new Rectangle(x, y, size, size);

        //    Rectangle boxRec = new Rectangle(b.x, b.y, b.size, b.size);

        //    if (thisRec.IntersectsWith(boxRec))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}

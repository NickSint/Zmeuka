﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeuka
{
    class Horizontal
    {
        List<Point> pList;

        public Horizontal()//конструктор
        {
            pList = new List<Point>();
            Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(5, 4, '*');
            Point p3 = new Point(6, 4, '*');
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
        }

        public void Draw()

    }
}

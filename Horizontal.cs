﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeuka
{
    class Horizontal : Figure
    {
       

        public Horizontal(int xLeft , int xReight, int y, char sym)//конструктор, передаем параметры
        {
            pList = new List<Point>();
            for (int x = xLeft; x < xReight; x++)
            {
                Point p = new Point(x, y, sym); // создаеи точку
                pList.Add(p);
            }
        }

       

    }
}

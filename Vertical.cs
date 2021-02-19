using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeuka
{
    class Vertical : Figure
    {
        

        public Vertical(int yUp, int yDown, int x, char sym)//конструктор, передаем параметры
        {
            pList = new List<Point>();
            for (int y = yUp; y <=  yDown; y++)
            {
                Point p = new Point(x, y, sym); // создаеи точку
                pList.Add(p);
            }
        }


    }
}
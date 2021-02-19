using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeuka
{
    class Figure
    {
        protected List<Point> pList; //protected - модификатор доступа что у всех наследников была видна переменая pList

        public void Drow()
        {
            foreach (Point p in pList) 
            {
                p.Draw(); 
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeuka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);

            // Отрисовка рамки
            Horizontal upline = new Horizontal(0, 78, 0, '+');
            Horizontal downline = new Horizontal(0, 78, 24, '+');
            Vertical leftline = new Vertical(0, 24, 0, '+');
            Vertical rightline = new Vertical(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            // Отрисовка точек
 
            Point p = new Point(4,5 ,'#');
            Snake snake = new Snake(p,4,Direction,RIGHT)
            

            Console.ReadLine();
        }
    }
}    

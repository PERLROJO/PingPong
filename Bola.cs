using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    class Bola
    {
        Ellipse rect = new Ellipse();
        //Rectangle rect = new Rectangle();
        public int x, y, t;
        int mov = 5;
        int xdir, ydir ;
        public Bola(Canvas c)
        {
            SolidColorBrush color = new SolidColorBrush();
            x = 80;
            y = 80;
            t = 25;
            xdir = mov;
            ydir = mov;
            color.Color = Color.FromRgb(100, 250, 50);
            rect.Fill = color;
            rect.Width = t;
            rect.Height = t;
            Canvas.SetTop(rect, y);
            Canvas.SetLeft(rect, x);
            c.Children.Add(rect);

        }
        public void movimiento()
        {
            Vector v = new Vector() { X = Math.Sin(x), Y = Math.Cos(y) };
            //v.X = x;
            //v.Y = y;
            x += xdir;
            y += ydir;
            Canvas.SetTop(rect, y);
            Canvas.SetLeft(rect, x);
        }
        public void rebotex()
        {
            if(xdir == 5)
            {
                xdir = -5;
            }
            else
            {
                xdir = 5;
            }
        }
        public void rebotey()
        {
            if (ydir == 5)
            {
                ydir = -5;
            }
            else
            {
                ydir = 5;
            }
        } 
    }
}

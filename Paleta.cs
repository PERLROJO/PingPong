using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace WpfApp1
{
    class Paleta
    {
        Rectangle rect = new Rectangle();
        public int x, y, w, h;
        int ydir = 0;
        public Paleta(Canvas c, int x)
        {
            SolidColorBrush color = new SolidColorBrush();
            color.Color = Color.FromRgb(50, 50, 100);
            rect.Fill = color;
            this.x = x;
            y = 80;
            w = 25;
            h = 75;
            rect.Width = w;
            rect.Height = h;
            Canvas.SetLeft(rect, this.x);
            Canvas.SetTop(rect, y);
            c.Children.Add(rect);
        }
        public void movimiento()
        {
            y += ydir;
            Canvas.SetTop(rect, y);
}
        public void bajar()
        {
            if(y >= 197)
            {
                ydir = 0;
            }
            else
            {
                ydir = 5;
            }
         }
        public void subir()
        {
            if (y <= 0)
            {
                ydir = 0;
            }
            else
            {
                ydir = -5;
            }
        }
        public void parar()
        {
            ydir = 0;
        }
    }
}

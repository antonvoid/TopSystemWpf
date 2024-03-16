using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TopSystemWpf
{
    public class DrawCircle(int W) : DrawEllipse(W, W)
    {
        public override Ellipse CreateEllipse()
        {
           
            Ellipse ellipse = new Ellipse
            {
                Width = W,
                Height = W,
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            return ellipse;
        }
    }
}

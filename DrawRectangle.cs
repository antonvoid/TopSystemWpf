using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TopSystemWpf
{
    public class DrawRectangle : DrawQuadrilateral
    {

        public DrawRectangle(PointCollection points) : base(points)
        {

        }

        public override Polygon CreationPolygon()
        {
            Polygon polygon = new Polygon
            {
                Fill = Brushes.Green,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            
            polygon.Points = points;
            return polygon;
        }
    }
}

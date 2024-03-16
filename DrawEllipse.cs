using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace TopSystemWpf
{
    public class DrawEllipse
    {
        protected int W {  get; set; }
        protected int H { get; set; }
        public DrawEllipse(int W, int H)
        {
            this.W = W;
            this.H = H;
        }
        public virtual Ellipse CreateEllipse()
        {
            Ellipse ellipse = new Ellipse
            {
                Width = W,
                Height = H,
                Fill = Brushes.Red,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            return ellipse;
        }       

    }
}

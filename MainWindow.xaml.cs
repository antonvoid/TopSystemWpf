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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            test.Children.Clear();
            try
            {
                if(t1.Text=="" || t2.Text=="")
                    throw new Exception($"Заполните поле");
                if(Convert.ToInt32(t1.Text) > 420 || Convert.ToInt32(t2.Text) > 300)
                    throw new Exception($"Ширина не должна превышать 420, а высота не должна превышать 300");
                DrawEllipse d = new DrawEllipse(Convert.ToInt32(t1.Text), Convert.ToInt32(t2.Text));
                Ellipse el = d.CreateEllipse();

                double centerX = (420 - el.Width) / 2; // центр по горизонтали
                double centerY = (300 - el.Height) / 2; // центр по вертикали

                Canvas.SetLeft(el, centerX);
                Canvas.SetTop(el, centerY);
                test.Children.Add(el);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            test.Children.Clear();
            try
            {
                if (t3.Text == "" )
                    throw new Exception($"Заполните поле");
                if (Convert.ToInt32(t3.Text) > 300)
                    throw new Exception($"Радиус не должен превышать 300");
                DrawCircle d = new DrawCircle(Convert.ToInt32(t3.Text));
                Ellipse el = d.CreateEllipse();

                double centerX = (420 - el.Width) / 2; // центр по горизонтали
                double centerY = (300 - el.Height) / 2; // центр по вертикали

                Canvas.SetLeft(el, centerX);
                Canvas.SetTop(el, centerY);

                test.Children.Add(el);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            
            
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            test.Children.Clear();
            try
            {
                if (t41.Text == ""|| t42.Text == ""|| t51.Text == ""|| t52.Text == ""|| t61.Text == ""|| t62.Text == "")
                    throw new Exception($"Заполните поле");
                if (Convert.ToInt32(t41.Text) > 200 || Convert.ToInt32(t42.Text) > 200 || Convert.ToInt32(t51.Text) > 200 || Convert.ToInt32(t52.Text) > 200 || Convert.ToInt32(t61.Text) > 200 || Convert.ToInt32(t62.Text) > 200)
                    throw new Exception($"Координаты не должены превышать 200");
                PointCollection points = new PointCollection();
                points.Add(new System.Windows.Point(Convert.ToInt32(t41.Text), Convert.ToInt32(t42.Text)));
                points.Add(new System.Windows.Point(Convert.ToInt32(t51.Text), Convert.ToInt32(t52.Text)));
                points.Add(new System.Windows.Point(Convert.ToInt32(t61.Text), Convert.ToInt32(t62.Text)));
                DrawTriangle d = new DrawTriangle(points);
                Polygon polygon = d.CreationPolygon();
                Canvas.SetLeft(polygon, 100);
                Canvas.SetTop(polygon, 100);

                test.Children.Add(polygon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            test.Children.Clear();
            try
            {
                if (t71.Text == "" || t72.Text == "" || t81.Text == "" || t82.Text == "" || t91.Text == "" || t92.Text == "" || t101.Text == "" || t102.Text == "")
                    throw new Exception($"Заполните поле");
                if (Convert.ToInt32(t71.Text) > 200 || Convert.ToInt32(t72.Text) > 200 || Convert.ToInt32(t81.Text) > 200 || Convert.ToInt32(t82.Text) > 200 || Convert.ToInt32(t91.Text) > 200 || Convert.ToInt32(t92.Text) > 200 || Convert.ToInt32(t101.Text) > 200 || Convert.ToInt32(t102.Text) > 200)
                    throw new Exception($"Координаты не должены превышать 200");
                PointCollection points = new PointCollection();
                points.Add(new System.Windows.Point(Convert.ToInt32(t71.Text), Convert.ToInt32(t72.Text)));
                points.Add(new System.Windows.Point(Convert.ToInt32(t81.Text), Convert.ToInt32(t82.Text)));
                points.Add(new System.Windows.Point(Convert.ToInt32(t91.Text), Convert.ToInt32(t92.Text)));
                points.Add(new System.Windows.Point(Convert.ToInt32(t101.Text), Convert.ToInt32(t102.Text)));
                DrawQuadrilateral d = new DrawQuadrilateral(points);
                Polygon polygon = d.CreationPolygon();

                Canvas.SetLeft(polygon, 100);
                Canvas.SetTop(polygon, 50);

                test.Children.Add(polygon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            test.Children.Clear();
            try
            {
                if (t11.Text == "" || t12.Text == "")
                    throw new Exception($"Заполните поле");
                if (Convert.ToInt32(t11.Text) > 420 || Convert.ToInt32(t12.Text) > 300)
                    throw new Exception($"Ширина не должна превышать 420, а высота не должна превышать 300");
                PointCollection points = new PointCollection();
                points.Add(new System.Windows.Point(50 + Convert.ToInt32(t11.Text), 50));
                points.Add(new System.Windows.Point(50, 50));
                points.Add(new System.Windows.Point(50, 50 + Convert.ToInt32(t12.Text)));
                points.Add(new System.Windows.Point(50 + Convert.ToInt32(t11.Text), 50 + Convert.ToInt32(t12.Text)));
                DrawRectangle d = new DrawRectangle(points);
                Polygon polygon = d.CreationPolygon();
                double centerX = (420 - Convert.ToInt32(t11.Text) - 100) / 2; // центр по горизонтали
                double centerY = (300 - Convert.ToInt32(t12.Text) - 100) / 2;
                Canvas.SetLeft(polygon, centerX);
                Canvas.SetTop(polygon, centerY);

                test.Children.Add(polygon);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            test.Children.Clear();
            try
            {
                if (t13.Text == "")
                    throw new Exception($"Заполните поле");
                if (Convert.ToInt32(t13.Text) > 300)
                    throw new Exception($"Сторона квадрата не должена превышать 300");
                PointCollection points = new PointCollection();
                points.Add(new System.Windows.Point(50 + Convert.ToInt32(t13.Text), 50));
                points.Add(new System.Windows.Point(50, 50));
                points.Add(new System.Windows.Point(50, 50 + Convert.ToInt32(t13.Text)));
                points.Add(new System.Windows.Point(50 + Convert.ToInt32(t13.Text), 50 + Convert.ToInt32(t13.Text)));
                DrawSquare d = new DrawSquare(points);
                Polygon polygon = d.CreationPolygon();
                double centerX = (420 - Convert.ToInt32(t13.Text) - 100) / 2; // центр по горизонтали
                double centerY = (300 - Convert.ToInt32(t13.Text) - 100) / 2;
                Canvas.SetLeft(polygon, centerX);
                Canvas.SetTop(polygon, centerY);

                test.Children.Add(polygon);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }
        private void OnlyDigit(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int numericValue))
            {
                e.Handled = true;
            }

        }
        

        private void text1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string messeg = "1.Рисует эллипс. Необходимо ввести ширину(не превышет 420) и высоту(не превышает 300) соответсвенно\n" +
                "2.Рисует круг. Необходимо ввести радиус(не превышает 300)\n" +
                "3.Рисует треугольник. Необходимо ввести координаты вершин(не превышают 200)\n" +
                "4.Рисует четырехугольник. Необходимо ввести координаты вершин(не превышают 200)\n" +
                "5.Рисует прямоугольник. Необходимо ввести ширину(не превышет 420) и высоту(не превышает 300) соответсвенно\n" +
                "6. Рисует квадрат. Необходимо ввести длину стороны(не превышает 300)";
            MessageBox.Show(messeg,"Инструкция", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
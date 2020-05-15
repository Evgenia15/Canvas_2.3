using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Canvas_2._3
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

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                Point point = e.GetPosition(canvas);
                Canvas.SetTop(rectangle, point.Y);
                Canvas.SetLeft(rectangle, point.X);
                textBlock.Text = "Координаты курсора (Y;X): " + point.ToString();
            }
        }

        private void key(object sender, KeyEventArgs e)
        {
            Key key = e.Key;
            textBlock.Text = ((int)key).ToString();
            textBlock.Text = "Последняя нажатая клавиша на клавиатуре: " + key.ToString();
        }

        
    }
}

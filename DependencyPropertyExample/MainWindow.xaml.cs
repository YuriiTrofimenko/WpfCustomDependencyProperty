using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyPropertyExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(newTestControl1.TestData.ToString());
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBlock1.Text = newTestControl1.TestData.ToString();

            ((LinearGradientBrush)rectangle1.Fill).GradientStops.ElementAt(0).Offset =
                ((double)newTestControl1.TestData) / 100;
            ((LinearGradientBrush)rectangle1.Fill).GradientStops.ElementAt(0).Color = Colors.LightSeaGreen;
            ((LinearGradientBrush)rectangle1.Fill).GradientStops.ElementAt(1).Offset =
                1 + (((float)newTestControl1.TestData) / 100);


            //LinearGradientBrush brush1 = new LinearGradientBrush();
            //brush1.StartPoint = new Point(0, 0.5);
            //brush1.EndPoint = new Point(1, 0.5);
            //brush1.GradientStops = new GradientStopCollection();

            //GradientStop gs = new GradientStop();
            //gs.Color = Colors.LightSeaGreen;
            //gs.Offset = ((double)newTestControl1.TestData) / 100;
            //brush1.GradientStops.Add(gs);

            //gs = new GradientStop();
            //gs.Color = Colors.BlueViolet;
            //gs.Offset = 1 + (((float)newTestControl1.TestData) / 100);
            //brush1.GradientStops.Add(gs);

            //rectangle1.Fill = brush1;
        }
    }
}

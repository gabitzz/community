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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Charts;


namespace RuntimeChart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateChart();
        }

        private void CreateChart()
        {
            ChartControl chart = new ChartControl();
            SimpleDiagram2D diagram = new SimpleDiagram2D();
            chart.Diagram = diagram;
            PieSeries2D series = new PieSeries2D();            
            series.DisplayName = "My Series";
            series.AnimationAutoStartMode = AnimationAutoStartMode.PlayOnce;
            series.Points.Add(new SeriesPoint("A", 1));
            series.Points.Add(new SeriesPoint("B", 2));
            series.Points.Add(new SeriesPoint("C", 6));
            series.Points.Add(new SeriesPoint("D", 5));
            series.Points.Add(new SeriesPoint("E", 3));
            Pie2DFadeInAnimation animation = new Pie2DFadeInAnimation();
            animation.Duration = new TimeSpan(0,0,3);
            animation.PointOrder = PointAnimationOrder.Random ;
            series.PointAnimation = animation;
            diagram.Series.Add(series);

            mainGrid.Children.Add(chart);
        }
    }
}

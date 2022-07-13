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

namespace FractalPainter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int pythagorasMaxRecursion = 6;
        private int kochMaxRecursion = 4;
        private int carpetMaxRecursion = 3;
        private int triangleMaxRecursion = 4;
        private int cantorMaxRecursion = 4;
        private int rightAngle = 45;
        private int leftAngle = 45;
        private double lengthRate = 0.7;
        private int distance = 30;
        
        /// <summary>
        /// Конструктор окна приложения.
        /// </summary>
        
        public MainWindow()
        {
            InitializeComponent();
            fractalCanvas.Children.Clear();
            pythagorasButton.Click += PythagorasButtonClick;
            kochButton.Click += KochButtonClick;
            carpetButton.Click += CarpetButtonClick;
            triangleButton.Click += TriangleButtonClick;
            cantorButton.Click += CantorButtonClick;
            saveButton.Click += SaveButtonClick;
        }
    }
}
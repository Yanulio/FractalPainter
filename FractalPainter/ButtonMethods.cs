using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace FractalPainter
{
    public partial class MainWindow
    {
        /// <summary>
        /// Метод-обработчик события клика по кнопке, создающий Дерево Пифагора. Очищает канву, показывает
        /// пользователю нужные элементы интерфейса и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-кнопку.</param>
        /// <param name="e">Событие клика по кнопке.</param>
        
        private void PythagorasButtonClick(object sender, RoutedEventArgs e)
        {
            fractalCanvas.Children.Clear();
            ShowPythagoras();
            FractalBase fractal = new PythagorasTree(pythagorasMaxRecursion, rightAngle, leftAngle, lengthRate);
            fractal.Draw(fractalCanvas, 450, 580, 450, 400);
        }
        
        /// <summary>
        /// Метод-обработчик события клика по кнопке, создающий Кривую Коха. Очищает канву, показывает
        /// пользователю нужные элементы интерфейса и рисует кривую-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-кнопку.</param>
        /// <param name="e">Событие клика по кнопке.</param>
        
        private void KochButtonClick(object sender, RoutedEventArgs e)
        {
            fractalCanvas.Children.Clear();
            ShowKoch();
            FractalBase fractal = new KochCurve(kochMaxRecursion);
            fractal.Draw(fractalCanvas, 50, 350, 850, 350);
        }
        
        /// <summary>
        /// Метод-обработчик события клика по кнопке, создающий Ковер Серпинского. Очищает канву, показывает
        /// пользователю нужные элементы интерфейса и рисует ковёр-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-кнопку.</param>
        /// <param name="e">Событие клика по кнопке.</param>
        
        private void CarpetButtonClick(object sender, RoutedEventArgs e)
        {
            fractalCanvas.Children.Clear();
            ShowCarpet();
            FractalBase fractal = new SierpinskiCarpet(carpetMaxRecursion);
            fractal.Draw(fractalCanvas, 150, 20, 750, 620);
        }
        
        /// <summary>
        /// Метод-обработчик события клика по кнопке, создающий Треугольник Серпинского. Очищает канву, показывает
        /// пользователю нужные элементы интерфейса и рисует треугольник-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-кнопку.</param>
        /// <param name="e">Событие клика по кнопке.</param>
       
        private void TriangleButtonClick(object sender, RoutedEventArgs e)
        {
            fractalCanvas.Children.Clear();
            ShowTriangle();
            FractalBase fractal = new SierpinskiTriangle(triangleMaxRecursion);
            fractal.Draw(fractalCanvas, 450, 40, 750, 560);
        }
        
        /// <summary>
        /// Метод-обработчик события клика по кнопке, создающий Множество Кантора. Очищает канву, показывает
        /// пользователю нужные элементы интерфейса и рисует множество-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-кнопку.</param>
        /// <param name="e">Событие клика по кнопке.</param>
        
        private void CantorButtonClick(object sender, RoutedEventArgs e)
        {
            fractalCanvas.Children.Clear();
            ShowCantor();
            FractalBase fractal = new CantorSet(cantorMaxRecursion, distance);
            fractal.Draw(fractalCanvas, 150, 150, 750, 150);
        }

        /// <summary>
        /// Метод-обработчик события клика по кнопке, сохраняющего в формате png фрактал.
        /// Часть кода была взята с:
        /// https://stackoverflow.com/questions/8881865/saving-a-wpf-canvas-as-an-image
        /// </summary>
        /// <param name="sender">Ссылка на объект-кнопку.</param>
        /// <param name="e">Событие клика по кнопке.</param>

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                RenderTargetBitmap rtb = new RenderTargetBitmap((int) fractalCanvas.RenderSize.Width, 
                (int) fractalCanvas.RenderSize.Height, 96d, 96d, PixelFormats.Default);
                rtb.Render(fractalCanvas);
                CroppedBitmap crop = new CroppedBitmap(rtb, new Int32Rect(0, 0, 
                (int) fractalCanvas.RenderSize.Width, (int) fractalCanvas.RenderSize.Height));
                BitmapEncoder pngEncoder = new PngBitmapEncoder();
                pngEncoder.Frames.Add(BitmapFrame.Create(crop));
                SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "PNG Files (*.png)|*.png" };
                if (saveFileDialog.ShowDialog() == true)
                {
                    var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    pngEncoder.Save(fileStream);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка! {ex.Message}", "Внимание!");
            }
        }
        
        /// <summary>
        /// Метод для показа пользователю элементов интерфейса, связанных с отрисовкой Дерева Пифагора.
        /// </summary>

        private void ShowPythagoras()
        {
            pythagorasDepthSlider.Visibility = Visibility.Visible;
            kochDepthSlider.Visibility = Visibility.Hidden;
            carpetDepthSlider.Visibility = Visibility.Hidden;
            triangleDepthSlider.Visibility = Visibility.Hidden;
            cantorDepthSlider.Visibility = Visibility.Hidden;
            recursionLabel.Visibility= Visibility.Visible;
        }
        
        /// <summary>
        /// Метод для показа пользователю элементов интерфейса, связанных с отрисовкой Кривой Коха.
        /// </summary>
        
        private void ShowKoch()
        {
            pythagorasDepthSlider.Visibility = Visibility.Hidden;
            kochDepthSlider.Visibility = Visibility.Visible;
            carpetDepthSlider.Visibility = Visibility.Hidden;
            triangleDepthSlider.Visibility = Visibility.Hidden;
            cantorDepthSlider.Visibility = Visibility.Hidden;
            recursionLabel.Visibility= Visibility.Visible;
        }
        
        /// <summary>
        /// Метод для показа пользователю элементов интерфейса, связанных с отрисовкой Ковра Серпинского.
        /// </summary>
        
        private void ShowCarpet()
        {
            pythagorasDepthSlider.Visibility = Visibility.Hidden;
            kochDepthSlider.Visibility = Visibility.Hidden;
            carpetDepthSlider.Visibility = Visibility.Visible;
            triangleDepthSlider.Visibility = Visibility.Hidden;
            cantorDepthSlider.Visibility = Visibility.Hidden;
            recursionLabel.Visibility= Visibility.Visible;
        }
        
        /// <summary>
        /// Метод для показа пользователю элементов интерфейса, связанных с отрисовкой Треугольника Серпинского.
        /// </summary>
        
        private void ShowTriangle()
        {
            pythagorasDepthSlider.Visibility = Visibility.Hidden;
            kochDepthSlider.Visibility = Visibility.Hidden;
            carpetDepthSlider.Visibility = Visibility.Hidden;
            triangleDepthSlider.Visibility = Visibility.Visible;
            cantorDepthSlider.Visibility = Visibility.Hidden;
            recursionLabel.Visibility= Visibility.Visible;
        }
        
        /// <summary>
        /// Метод для показа пользователю элементов интерфейса, связанных с отрисовкой Множества Кантора.
        /// </summary>
        
        private void ShowCantor()
        {
            pythagorasDepthSlider.Visibility = Visibility.Hidden;
            kochDepthSlider.Visibility = Visibility.Hidden;
            carpetDepthSlider.Visibility = Visibility.Hidden;
            triangleDepthSlider.Visibility = Visibility.Hidden;
            cantorDepthSlider.Visibility = Visibility.Visible;
            recursionLabel.Visibility= Visibility.Visible;
        }
    }
}
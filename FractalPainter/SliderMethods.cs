using System.Windows;

namespace FractalPainter
{
    public partial class MainWindow
    {
        /// <summary>
        /// Метод-обработчик события изменения значения слайдера, отвечающего за глубину рекурсии
        /// Дерева Пифагора. Меняет значение соответствующего поля, очищает канву и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-слайдер.</param>
        /// <param name="e">Событие изменения значения слайдера.</param>
        private void PythagorasDepthSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            pythagorasMaxRecursion = (int) pythagorasDepthSlider.Value;
            fractalCanvas.Children.Clear();
            FractalBase fractal = new PythagorasTree(pythagorasMaxRecursion, rightAngle, leftAngle, lengthRate);
            fractal.Draw(fractalCanvas, 450, 580, 450, 400);
        }
        
        /// <summary>
        /// Метод-обработчик события изменения значения слайдера, отвечающего за угол правой ветви
        /// Дерева Пифагора. Меняет значение соответствующего поля, очищает канву и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-слайдер.</param>
        /// <param name="e">Событие изменения значения слайдера.</param>
        
        private void PythagorasRightAngleSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            fractalCanvas.Children.Clear();
            rightAngle = (int) pythagorasRightAngleSlider.Value;
            FractalBase fractal = new PythagorasTree(pythagorasMaxRecursion, rightAngle, leftAngle, lengthRate);
            fractal.Draw(fractalCanvas, 450, 580, 450, 400);
        }
        
        /// <summary>
        /// Метод-обработчик события изменения значения слайдера, отвечающего за угол левой ветви
        /// Дерева Пифагора. Меняет значение соответствующего поля, очищает канву и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-слайдер.</param>
        /// <param name="e">Событие изменения значения слайдера.</param>
        
        private void PythagorasLeftAngleSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            fractalCanvas.Children.Clear();
            leftAngle = (int) pythagorasLeftAngleSlider.Value;
            FractalBase fractal = new PythagorasTree(pythagorasMaxRecursion, rightAngle, leftAngle, lengthRate);
            fractal.Draw(fractalCanvas, 450, 580, 450, 400);
        }
        
        /// <summary>
        /// Метод-обработчик события изменения значения слайдера, отвечающего за отношение отрезков ветвей
        /// Дерева Пифагора. Меняет значение соответствующего поля, очищает канву и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-слайдер.</param>
        /// <param name="e">Событие изменения значения слайдера.</param>
        
        private void PythagorasLengthRateSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            fractalCanvas.Children.Clear();
            lengthRate = pythagorasLengthRateSlider.Value;
            FractalBase fractal = new PythagorasTree(pythagorasMaxRecursion, rightAngle, leftAngle, lengthRate);
            fractal.Draw(fractalCanvas, 450, 580, 450, 400);
        }
        
        /// <summary>
        /// Метод-обработчик события изменения значения слайдера, отвечающего за глубину рекурсии
        /// Кривой Коха. Меняет значение соответствующего поля, очищает канву и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-слайдер.</param>
        /// <param name="e">Событие изменения значения слайдера.</param>
        
        private void KochDepthSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kochMaxRecursion = (int) kochDepthSlider.Value;
            fractalCanvas.Children.Clear();
            FractalBase fractal = new KochCurve(kochMaxRecursion);
            fractal.Draw(fractalCanvas, 50, 350, 850, 350);
        }
        
        /// <summary>
        /// Метод-обработчик события изменения значения слайдера, отвечающего за глубину рекурсии
        /// Ковра Серпинского. Меняет значение соответствующего поля, очищает канву и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-слайдер.</param>
        /// <param name="e">Событие изменения значения слайдера.</param>
        
        private void CarpetDepthSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            carpetMaxRecursion = (int) carpetDepthSlider.Value;
            fractalCanvas.Children.Clear();
            FractalBase fractal = new SierpinskiCarpet(carpetMaxRecursion);
            fractal.Draw(fractalCanvas, 150, 20, 750, 620);
        }
        
        /// <summary>
        /// Метод-обработчик события изменения значения слайдера, отвечающего за глубину рекурсии
        /// Треугольника Серпинского. Меняет значение соответствующего поля, очищает канву и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-слайдер.</param>
        /// <param name="e">Событие изменения значения слайдера.</param>
        
        private void TriangleDepthSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            triangleMaxRecursion = (int) triangleDepthSlider.Value;
            fractalCanvas.Children.Clear();
            FractalBase fractal = new SierpinskiTriangle(triangleMaxRecursion);
            fractal.Draw(fractalCanvas, 450, 40, 750, 560);
        }
        
        /// <summary>
        /// Метод-обработчик события изменения значения слайдера, отвечающего за глубину рекурсии
        /// Множества Кантора. Меняет значение соответствующего поля, очищает канву и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-слайдер.</param>
        /// <param name="e">Событие изменения значения слайдера.</param>
        
        private void CantorDepthSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cantorMaxRecursion = (int) cantorDepthSlider.Value;
            fractalCanvas.Children.Clear();
            FractalBase fractal = new CantorSet(cantorMaxRecursion, distance);
            fractal.Draw(fractalCanvas, 150, 150, 750, 150);
        }
        
        /// <summary>
        /// Метод-обработчик события изменения значения слайдера, отвечающего за расстояние между отрезками
        /// Множества Кантора. Меняет значение соответствующего поля, очищает канву и рисует дерево-фрактал.
        /// </summary>
        /// <param name="sender">Ссылка на объект-слайдер.</param>
        /// <param name="e">Событие изменения значения слайдера.</param>
        
        private void CantorDistanceSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            distance = (int) cantorDistanceSlider.Value;
            fractalCanvas.Children.Clear();
            FractalBase fractal = new CantorSet(cantorMaxRecursion, distance);
            fractal.Draw(fractalCanvas, 150, 150, 750, 150);
        }

    }
}
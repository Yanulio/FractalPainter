using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FractalPainter
{
    /// <summary>
    /// Класс для создания и отрисовки фрактала - Дерева Пифагора.
    /// </summary>
    public class PythagorasTree : FractalBase
    {
        private readonly double rightAngle;
        private readonly double leftAngle;
        private readonly double lengthRate;

        /// <summary>
        /// Конструктор Дерева Пифагора.
        /// </summary>
        /// <param name="maxRecursionDepth">Максимальная глубина рекурсии. Количество итераций для фрактала.</param>
        /// <param name="rightAngle">Угол правой ветви дерева, отложенный от вертикальной оси.</param>
        /// <param name="leftAngle">Угол левой ветви дерева, отложенный от вертикальной оси.</param>
        /// <param name="lengthRate">Отношение длины каждого следущего отрезка к длине предыдущего.</param>
        public PythagorasTree(int maxRecursionDepth, double rightAngle, double leftAngle, 
            double lengthRate) : base(maxRecursionDepth)
        {
            this.rightAngle = rightAngle;
            this.leftAngle = leftAngle;
            this.lengthRate = lengthRate;
        }
        
        /// <summary>
        /// Метод для отрисовки фрактала - Дерева Пифагора.
        /// </summary>
        /// <param name="canvas">Канва для отрисовки линий.</param>
        /// <param name="xStart">Х-координата начальной точки исходной линии.</param>
        /// <param name="yStart">Y-координата начальной точки исходной линии.</param>
        /// <param name="xEnd">Х-координата конечной точки исходной линии.</param>
        /// <param name="yEnd">Y-координата конечной точки исходной линии.</param>
        /// <param name="recursionDepth">Количество предыдущих итераций.</param>
        /// <param name="addedAngle">Угол, вычитающийся или прибавляющийся к исходному
        /// на каждой следующей итерации.</param>

        public override void Draw(Canvas canvas, int xStart, int yStart, int xEnd, int yEnd, 
            int recursionDepth = 0, double addedAngle = 0)
        {
            if (recursionDepth >= MaxRecursionDepth)
            {
                return;
            }
            else
            {
                SolidColorBrush lineColor = new SolidColorBrush();
                lineColor.Color = Colors.Aqua;
                Line line = new Line
                    {
                        X1 = xStart, Y1 = yStart,
                        X2 = xEnd, Y2 = yEnd,
                        StrokeThickness = 2, Stroke = lineColor,
                    };
                canvas.Children.Add(line);
                double length = Math.Sqrt(Math.Pow(xEnd - xStart, 2) + Math.Pow(yEnd - yStart, 2)) * lengthRate;
                int leftX = xEnd - (int) (Math.Sin((leftAngle - addedAngle) * Math.PI / 180) * length);
                int leftY = yEnd - (int) (Math.Cos((leftAngle - addedAngle) * Math.PI / 180) * length);
                int rightX = xEnd + (int) (Math.Sin((rightAngle + addedAngle) * Math.PI / 180) * length);
                int rightY = yEnd - (int) (Math.Cos((rightAngle + addedAngle) * Math.PI / 180) * length);
                Draw(canvas, xEnd, yEnd, leftX, leftY, 
                    recursionDepth + 1,addedAngle - leftAngle);
                Draw(canvas, xEnd, yEnd, rightX, rightY, 
                    recursionDepth + 1,addedAngle + rightAngle);
            }
        }
    }
}
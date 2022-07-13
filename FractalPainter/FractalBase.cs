using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FractalPainter
{
    /// <summary>
    /// Базовый класс для создания фрактала.
    /// </summary>
    public abstract class FractalBase
    {
        protected int MaxRecursionDepth { get; set; }
        
        /// <summary>
        /// Конструктор базового класса фракталов, задающий максимальную глубину рекурсии.
        /// </summary>
        /// <param name="maxRecursionDepth">Максимальная глубина рекурсии. Количество итераций для фрактала.</param>
        
        protected FractalBase(int maxRecursionDepth)
        {
            MaxRecursionDepth = maxRecursionDepth;
        }
        
        /// <summary>
        /// Базовый абстрактный метод отрисовки фрактала.
        /// </summary>
        /// <param name="canvas">Канва для отрисовки фигур.</param>
        /// <param name="xStart">Х-координата начальной точки исходной фигуры.</param>
        /// <param name="yStart">Y-координата начальной точки исходной фигуры.</param>
        /// <param name="xEnd">Х-координата конечной точки исходной фигуры.</param>
        /// <param name="yEnd">Y-координата конечной точки исходной фигуры.</param>
        /// <param name="recursionDepth">Количество предыдущих итераций.</param>
        /// <param name="addedAngle">Опциональный параметр для построения Дерева Пифагора.</param>

        public abstract void Draw(Canvas canvas, int xStart, int yStart, int xEnd, int yEnd, 
            int recursionDepth = 0,
            double addedAngle = 0);

        /// <summary>
        /// Метод для создания линии и её отрисовки на канве.
        /// </summary>
        /// <param name="canvas">Канва для отрисовки линии.</param>
        /// <param name="xStart">Х-координата начальной точки исходной линии.</param>
        /// <param name="yStart">Y-координата начальной точки исходной линии.</param>
        /// <param name="xEnd">Х-координата конечной точки исходной линии.</param>
        /// <param name="yEnd">Y-координата конечной точки исходной линии.</param>
        /// <param name="color">Цвет линии.</param>
        /// <param name="thickness">Размер линии.</param>
        /// <returns>Получившаяся линия.</returns>
        
        public Line CreateLine(Canvas canvas, int xStart, int yStart, int xEnd, int yEnd, Color color, int thickness)
        {
            SolidColorBrush lineColor = new SolidColorBrush();
            lineColor.Color = color;
            Line line = new Line
            {
                X1 = xStart, Y1 = yStart,
                X2 = xEnd, Y2 = yEnd,
                StrokeThickness = thickness, Stroke = lineColor,
            };
            canvas.Children.Add(line);
            return line;
        }
    }
}
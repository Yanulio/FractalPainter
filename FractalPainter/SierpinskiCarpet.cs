using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FractalPainter
{
    /// <summary>
    /// Класс для создания и отрисовки фрактала - Ковра Серпинского.
    /// </summary>
    public class SierpinskiCarpet : FractalBase
    {
        /// <summary>
        /// Конструктор Ковра Серпинского.
        /// </summary>
        /// <param name="maxRecursionDepth">Максимальная глубина рекурсии. Количество итераций для фрактала.</param>
        public SierpinskiCarpet(int maxRecursionDepth) : base(maxRecursionDepth) { }

        /// <summary>
        /// Метод для отрисовки фрактала - Ковра Серпинского.
        /// </summary>
        /// <param name="canvas">Канва для отрисовки квадратов.</param>
        /// <param name="xStart">Х-координата верхней левой вершины исходного квадрата.</param>
        /// <param name="yStart">Y-координата верхней левой вершины исходного квадрата.</param>
        /// <param name="xStart">Х-координата нижней правой вершины исходного квадрата.</param>
        /// <param name="yEnd">Y-координата нижней правой вершины исходного квадрата.</param>
        /// <param name="recursionDepth">Количество предыдущих итераций.</param>
        /// <param name="addedAngle">Опциональный параметр другого фрактала.</param>
        
        public override void Draw(Canvas canvas, int xStart, int yStart, int xEnd, int yEnd,
            int recursionDepth = 0, double addedAngle = 0)
        {
            if (recursionDepth >= MaxRecursionDepth)
            {
                return;
            }
            else if (recursionDepth == 0)
            {
                DrawRectangle(canvas, xStart, yStart, xEnd, yEnd, Colors.DarkMagenta);
                Draw(canvas, xStart, yStart, xEnd, yEnd, 1);
            }
            else
            {
                int xStartWhite = xStart + (xEnd - xStart) / 3;
                int yStartWhite = yStart + (yEnd - yStart) / 3;
                int xEndWhite = xEnd - (xEnd - xStart) / 3;
                int yEndWhite = yEnd - (yEnd - yStart) / 3;
                DrawRectangle(canvas, xStartWhite, yStartWhite, xEndWhite, yEndWhite, Colors.WhiteSmoke);
                Draw(canvas, xStart, yStart, xStartWhite, yStartWhite, recursionDepth + 1);
                Draw(canvas, xStartWhite, yStart, xEndWhite, yStartWhite, recursionDepth + 1);
                Draw(canvas, xEndWhite, yStart, xEnd, yStartWhite, recursionDepth + 1);
                Draw(canvas, xStart, yStartWhite, xStartWhite, yEndWhite, recursionDepth + 1);
                Draw(canvas, xEndWhite, yStartWhite, xEnd, yEndWhite, recursionDepth + 1);
                Draw(canvas, xStart, yEndWhite, xStartWhite, yEnd, recursionDepth + 1);
                Draw(canvas, xStartWhite, yEndWhite, xEndWhite, yEnd, recursionDepth + 1);
                Draw(canvas, xEndWhite, yEndWhite, xEnd, yEnd, recursionDepth + 1);
            }
        }
        
        /// <summary>
        /// Метод для создания квадрата и его отрисовки на канве.
        /// </summary>
        /// <param name="canvas">Канва для отрисовки квадрата.</param>
        /// <param name="xStart">Х-координата верхней левой вершины исходного квадрата.</param>
        /// <param name="yStart">Y-координата верхней левой вершины исходного квадрата.</param>
        /// <param name="xStart">Х-координата нижней правой вершины исходного квадрата.</param>
        /// <param name="yEnd">Y-координата нижней правой вершины исходного квадрата.</param>
        /// <param name="color">Цвет заливки квадрата.</param>
        /// <returns>Получившийся квадрат.</returns>

        public Rectangle DrawRectangle(Canvas canvas, int xStart, int yStart, int xEnd, int yEnd, Color color)
        {
            SolidColorBrush fillColor = new SolidColorBrush();
            fillColor.Color = color;
            Rectangle rectangle = new Rectangle()
            {
                Width = xEnd - xStart,
                Height = yEnd - yStart,
                Fill = fillColor
            };
            Canvas.SetLeft(rectangle, xStart);
            Canvas.SetTop(rectangle, yStart);
            canvas.Children.Add(rectangle);
            return rectangle;
        }
    }
}
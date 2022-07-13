using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FractalPainter
{
    /// <summary>
    /// Класс для создания и отрисовки фрактала - Множества Кантора.
    /// </summary>
    public class CantorSet : FractalBase
    {
        private readonly int distance;
        
        /// <summary>
        /// Конструктор Множества Кантора.
        /// </summary>
        /// <param name="maxRecursionDepth">Максимальная глубина рекурсии. Количество итераций для фрактала.</param>
        /// <param name="distance">Расстояние между линиями во Множестве Кантора.</param>
        
        public CantorSet(int maxRecursionDepth, int distance) : base(maxRecursionDepth)
        {
            this.distance = distance;
        }

        /// <summary>
        /// Метод для отрисовки фрактала - Множества Кантора.
        /// </summary>
        /// <param name="canvas">Канва для отрисовки линий.</param>
        /// <param name="xStart">Х-координата начальной точки исходной линии.</param>
        /// <param name="yStart">Y-координата начальной точки исходной линии.</param>
        /// <param name="xEnd">Х-координата конечной точки исходной линии.</param>
        /// <param name="yEnd">Y-координата конечной точки исходной линии.</param>
        /// <param name="recursionDepth">Количество предыдущих итераций.</param>
        /// <param name="addedAngle">Опциональный параметр другого фрактала.</param>
        
        public override void Draw(Canvas canvas, int xStart, int yStart, int xEnd, int yEnd,
            int recursionDepth = 0, double addedAngle = 0)
        {
            if (recursionDepth >= MaxRecursionDepth)
            {
                return;
            }
            else
            {
                CreateLine(canvas, xStart, yStart, xEnd, yEnd, Colors.Aqua, 3);
                int xLeft = xStart + (xEnd - xStart) / 3;
                int yLeft = yStart + distance;
                int xRight = xStart + (xEnd - xStart) * 2 / 3;
                int yRight = yLeft;
                
                Draw(canvas, xStart, yLeft, xLeft, yLeft, recursionDepth + 1);
                Draw(canvas, xRight, yRight, xEnd, yRight, recursionDepth + 1);
            }
        }
    }
}
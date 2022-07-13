using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FractalPainter
{
    /// <summary>
    /// Класс для создания и отрисовки фрактала - Треугольника Серпинского.
    /// </summary>
    public class SierpinskiTriangle : FractalBase
    {
        /// <summary>
        /// Конструктор Треугольника Серпинского.
        /// </summary>
        /// <param name="maxRecursionDepth">Максимальная глубина рекурсии. Количество итераций для фрактала.</param>
        public SierpinskiTriangle(int maxRecursionDepth) : base(maxRecursionDepth) { }

        /// <summary>
        /// Метод для отрисовки фрактала - Треугольника Серпинского.
        /// </summary>
        /// <param name="canvas">Канва для отрисовки линий.</param>
        /// <param name="xStart">Х-координата верхней вершины треугольника.</param>
        /// <param name="yStart">Y-координата верхней вершины треугольника.</param>
        /// <param name="xEnd">Х-координата нижней правой вершины треугольника.</param>
        /// <param name="yEnd">Y-координата нижней правой вершины треугольника.</param>
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
                CreateLine(canvas, xStart, yStart, xEnd, yEnd, Colors.Aqua, 2);
                int xThirdPoint = xStart - (xEnd - xStart);
                int yThirdPoint = yEnd;
                CreateLine(canvas, xStart, yStart, xThirdPoint, yThirdPoint, Colors.Aqua, 2);
                CreateLine(canvas, xEnd, yEnd, xThirdPoint, yThirdPoint, Colors.Aqua, 2);
                Draw(canvas, xStart, yStart, xEnd, yEnd, 1);
            }
            else
            {
                int xThirdPoint = xStart - (xEnd - xStart);
                int yThirdPoint = yEnd;
                
                int xFirstMiddle = (xEnd + xStart) / 2;
                int yFirstMiddle = (yEnd + yStart) / 2;
                int xSecondMiddle = (xEnd + xThirdPoint) / 2;
                int ySecondMiddle = yEnd;
                int xThirdMiddle = (xStart + xThirdPoint) / 2;
                int yThirdMiddle = (yThirdPoint + yStart) / 2;
                
                CreateLine(canvas, xFirstMiddle, yFirstMiddle, xSecondMiddle, ySecondMiddle,
                    Colors.Aqua, 2);
                CreateLine(canvas, xThirdMiddle, yThirdMiddle, xSecondMiddle, ySecondMiddle,
                    Colors.Aqua, 2);
                CreateLine(canvas, xFirstMiddle, yFirstMiddle, xThirdMiddle, yThirdMiddle,
                    Colors.Aqua, 2);
                Draw(canvas, xStart, yStart, xFirstMiddle, yFirstMiddle, recursionDepth + 1);
                Draw(canvas, xFirstMiddle, yFirstMiddle, xEnd, yEnd, recursionDepth + 1);
                Draw(canvas, xThirdMiddle, yThirdMiddle, xSecondMiddle, ySecondMiddle, recursionDepth + 1);
            }
        }
    }
}
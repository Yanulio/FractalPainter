using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FractalPainter
{
    /// <summary>
    /// Класс для создания и отрисовки фрактала - Кривой Коха.
    /// </summary>
    public class KochCurve : FractalBase
    {
        /// <summary>
        /// Конструктор Кривой Коха.
        /// </summary>
        /// <param name="maxRecursionDepth">Максимальная глубина рекурсии. Количество итераций для фрактала.</param>
        public KochCurve(int maxRecursionDepth) : base(maxRecursionDepth) { }
        
        /// <summary>
        /// Метод для отрисовки фрактала - Кривой Коха.
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
            else if (recursionDepth < MaxRecursionDepth - 1)
            {
                int firstDivisionX = xStart + (xEnd - xStart) / 3;
                int secondDivisionX = xStart + (xEnd - xStart) * 2 / 3;
                int firstDivisionY = yStart + (yEnd - yStart) / 3;
                int secondDivisionY = yStart + (yEnd - yStart) * 2 / 3;
                (int trianglePointX, int trianglePointY) = GetNewPoint(xStart, yStart, xEnd, yEnd,
                    firstDivisionX, firstDivisionY, secondDivisionX, secondDivisionY);
                Draw(canvas, xStart, yStart, firstDivisionX, firstDivisionY, recursionDepth + 1);
                Draw(canvas, firstDivisionX, firstDivisionY, trianglePointX, trianglePointY, 
                    recursionDepth + 1);
                Draw(canvas, trianglePointX, trianglePointY, secondDivisionX, secondDivisionY, 
                    recursionDepth + 1);
                Draw(canvas, secondDivisionX, secondDivisionY, xEnd, yEnd, recursionDepth + 1);
            }
            else if (recursionDepth == MaxRecursionDepth - 1)
            {
                CreateLine(canvas, xStart, yStart, xEnd, yEnd, Colors.Aqua, 2);
            }
        }
        
        /// <summary>
        /// Метод для нахождения точки выступа у линии при построении Кривой Коха. (Размер метода немного превышает
        /// 40 строк, но пощадите, пожалуйста, тут много условий 0_0)
        /// </summary>
        /// <param name="xStart">Х-координата начальной точки исходной линии.</param>
        /// <param name="yStart">Y-координата начальной точки исходной линии.</param>
        /// <param name="xEnd">Х-координата конечной точки исходной линии.</param>
        /// <param name="yEnd">Y-координата конечной точки исходной линии.</param>
        /// <param name="firstDivisionX">Х-координата точки, отделяющей первую треть линии.</param>
        /// <param name="firstDivisionY">Y-координата точки, отделяющей первую треть линии.</param>
        /// <param name="secondDivisionX">Х-координата точки, отделяющей вторую треть линии.</param>
        /// <param name="secondDivisionY">Y-координата точки, отделяющей вторую треть линии.</param>
        /// <returns>Координаты точки, выступающая за пределы линии в Кривой Коха.</returns>

        public (int trianglePointX, int trianglePointY) GetNewPoint(int xStart, int yStart, int xEnd, int yEnd,
            int firstDivisionX, int firstDivisionY, int secondDivisionX, int secondDivisionY)
        {
            int length = (int) Math.Sqrt(Math.Pow(firstDivisionX - secondDivisionX, 2) + 
                                         Math.Pow(firstDivisionY - secondDivisionY, 2));
            int trianglePointX = 0, trianglePointY = 0;
            if (yEnd == yStart)
            {
                if (xStart < xEnd)
                {
                    trianglePointX = xStart + (xEnd - xStart) / 2;
                    trianglePointY = (int)(yStart - (trianglePointX - firstDivisionX) * Math.Tan(Math.PI / 3));
                }
                else
                {
                    trianglePointX = xStart - (xStart - xEnd) / 2;
                    trianglePointY = (int)(yStart + (firstDivisionX - trianglePointX) * Math.Tan(Math.PI / 3));
                }
            }
            else if (yEnd < yStart)
            {
                if (xStart < xEnd)
                {
                    trianglePointX = secondDivisionX - length;
                    trianglePointY = secondDivisionY;
                }
                else
                {
                    trianglePointX = firstDivisionX - length;
                    trianglePointY = firstDivisionY;
                }
            }
            else
            {
                if (xStart < xEnd)
                {
                    trianglePointX = firstDivisionX + length;
                    trianglePointY = firstDivisionY;
                }
                else
                {
                    trianglePointX = secondDivisionX + length;
                    trianglePointY = secondDivisionY;
                }
            }
            return (trianglePointX, trianglePointY);
        }
    }
}
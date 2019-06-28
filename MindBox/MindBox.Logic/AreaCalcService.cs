namespace MindBox.Logic
{
    /// <summary>
    /// Сервис вычисления площади геометрической фигуры ("Вычисление площади фигуры без знания типа фигуры")
    /// PS В данной ситуации не несет никакой полезной функции - просто пример блока, реализующего подмену типов во время исполнения
    /// </summary>
    public class AreaCalcService
    {
        public static double GetFigureArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}

using System.Collections.Generic;

namespace Model.OCP
{
    public class DrawingShapes
    {
        IList<IShape> _shapes = new List<IShape>();

        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
        }
        public void RemoveShape(IShape shape)
        {
            _shapes.Remove(shape);
        }

        public void DrawImages()
        {
            foreach (var shape in _shapes)
            {
                shape.DrawShape();
            }
        }
    }
}
internal class AnalogStickRepresentation
{
    private const int MINIMUM_POSITION_THRESHOLD = 32768;
    private const Double MAXIMUM_POSITION_THRESHOLD = 65535.0;

    internal Rectangle Area { get; set; }
    internal Point CurrentPosition { get; set; }

    internal AnalogStickRepresentation(Rectangle area)
    {
        Area = area;
    }

    internal void Draw(Graphics graphics, Pen pen, SolidBrush brush)
    {
        graphics.DrawEllipse(pen, Area);
        DrawCross(graphics, CurrentPosition, brush.Color);
    }

    private void DrawCross(Graphics graphics, Point position, Color color)
    {
        int crossSize = 10;
        int crossWidth = 2;

        using (Pen pen = new Pen(color, crossWidth))
        {
            graphics.DrawLine(pen, position.X - crossSize / crossWidth, position.Y, position.X + crossSize / crossWidth, position.Y);
            graphics.DrawLine(pen, position.X, position.Y - crossSize / crossWidth, position.X, position.Y + crossSize / crossWidth);
        }
    }

    internal void UpdatePosition(short rawX, short rawY)
    {
        int x = (int)Math.Round((rawX + MINIMUM_POSITION_THRESHOLD) * (Area.Width / MAXIMUM_POSITION_THRESHOLD) + Area.Left);
        int y = (int)Math.Round((rawY + MINIMUM_POSITION_THRESHOLD) * (Area.Height / MAXIMUM_POSITION_THRESHOLD) + Area.Top);

        x = Math.Max(Area.Left, Math.Min(Area.Right, x));
        y = Math.Max(Area.Top, Math.Min(Area.Bottom, y));

        CurrentPosition = new Point(x, y);
    }
}

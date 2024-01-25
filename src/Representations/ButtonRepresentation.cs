using SharpDX.XInput;

internal class ButtonRepresentation
{
    internal Point Position { get; set; }
    internal Size Size { get; set; }
    internal Color Color { get; set; }
    internal GamepadButtonFlags ButtonFlag { get; set; }

    internal ButtonRepresentation(Point position, Size size, GamepadButtonFlags flags, Color color)
    {
        Position = position;
        Size = size;
        ButtonFlag = flags;
        Color = color;

    }

    internal void Draw(Graphics graphics, GamepadButtonFlags currentFlags)
    {
        if (currentFlags.HasFlag(ButtonFlag))
        {
            graphics.FillEllipse(new SolidBrush(Color), new Rectangle(Position, Size));
        }
    }
}

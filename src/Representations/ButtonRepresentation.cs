using SharpDX.XInput;

internal class ButtonRepresentation
{
    internal Point Position { get; set; }
    internal Size Size { get; set; }
    internal GamepadButtonFlags ButtonFlag { get; set; }

    internal ButtonRepresentation(Point position, Size size, GamepadButtonFlags flags)
    {
        Position = position;
        Size = size;
        ButtonFlag = flags;
    }

    internal void Draw(Graphics graphics, SolidBrush brush, GamepadButtonFlags currentFlags)
    {
        if (currentFlags.HasFlag(ButtonFlag))
        {
            graphics.FillEllipse(brush, new Rectangle(Position, Size));
        }
    }
}

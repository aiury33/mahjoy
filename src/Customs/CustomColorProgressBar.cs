public class CustomColorProgressBar : ProgressBar
{
    public Color Color { get; set; }

    public CustomColorProgressBar(Color color)
    {
        this.SetStyle(ControlStyles.UserPaint, true);
        Color = color;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rect = ClientRectangle;
        Graphics g = e.Graphics;

        ProgressBarRenderer.DrawHorizontalBar(g, rect);
        rect.Inflate(-3, -3); 

        if (Value > 0)
        {
            Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round((float)Value / Maximum * rect.Width), rect.Height);

            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, clip);
            }
        }
    }
}

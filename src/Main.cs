using SharpDX.XInput;

namespace mahjoy
{
    public partial class Main : Form
    {
        private const byte LEFT_STICK = 0;
        private const byte RIGHT_STICK = 1;
        private const byte TRIGGER_THRESHOLD = 100;

        private MyController myController;

        private List<ButtonRepresentation> buttons = new List<ButtonRepresentation> { };
        private List<AnalogStickRepresentation> sticks = new List<AnalogStickRepresentation> { };


        public Main()
        {
            InitializeComponent();
            InitializeControllerComponents();

            myController = new MyController(new Controller(UserIndex.One));
            myController.ControllerPollingTimer.Tick += ControllerPollingTimer_Tick;
            myController.ControllerPollingTimer.Start();
        }

        private void ControllerPollingTimer_Tick(object sender, EventArgs e)
        {
            if (myController.Controller.IsConnected)
            {
                myController.ControllerState = myController.Controller.GetState();
                UpdateUIBasedOnState();

                picController.Invalidate();
            }
        }

        private void UpdateUIBasedOnState()
        {
            UpdateButtonUI(pnlR1, myController.ControllerState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder));
            UpdateButtonUI(pnlL1, myController.ControllerState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder));

            UpdateTriggerUI(pnlR2, myController.ControllerState.Gamepad.RightTrigger);
            UpdateTriggerUI(pnlL2, myController.ControllerState.Gamepad.LeftTrigger);
        }

        private void UpdateTriggerUI(Panel panel, byte triggerValue)
        {
            bool isPressed = triggerValue > TRIGGER_THRESHOLD;
            UpdateButtonUI(panel, isPressed);
        }

        private void picController_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush violetBrush = new SolidBrush(Color.Violet))
            {
                foreach (var button in buttons)
                {
                    button.Draw(e.Graphics, violetBrush, myController.ControllerState.Gamepad.Buttons);
                }

                sticks[LEFT_STICK].UpdatePosition(myController.ControllerState.Gamepad.LeftThumbX, (short)(myController.ControllerState.Gamepad.LeftThumbY * -1));
                sticks[LEFT_STICK].Draw(e.Graphics, Pens.Black, violetBrush);

                sticks[RIGHT_STICK].UpdatePosition(myController.ControllerState.Gamepad.RightThumbX, (short)(myController.ControllerState.Gamepad.RightThumbY * -1));
                sticks[RIGHT_STICK].Draw(e.Graphics, Pens.Black, violetBrush);
            }
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateButtonUI(Panel panel, bool isPressed)
        {
            if (panel.IsDisposed || !panel.IsHandleCreated || !panel.FindForm().Visible)
                return;

            Color color = isPressed ? Color.Violet : Color.Black;

            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(() => panel.BackColor = color));
            }
            else
            {
                panel.BackColor = color;
            }
        }

        private void InitializeControllerComponents()
        {
            Size sizeMainButtons = new Size(44, 44);
            Size sizeSideButtons = new Size(30, 30);
            Size sizeHorizontalArrow = new Size(27, 31);
            Size sizeVerticalArrow = new Size(31, 27);

            buttons.Add(new ButtonRepresentation(new Point(408, 106), sizeMainButtons, GamepadButtonFlags.X));
            buttons.Add(new ButtonRepresentation(new Point(451, 149), sizeMainButtons, GamepadButtonFlags.A));
            buttons.Add(new ButtonRepresentation(new Point(451, 63), sizeMainButtons, GamepadButtonFlags.Y));
            buttons.Add(new ButtonRepresentation(new Point(491, 106), sizeMainButtons, GamepadButtonFlags.B));

            buttons.Add(new ButtonRepresentation(new Point(343, 112), sizeSideButtons, GamepadButtonFlags.Start));
            buttons.Add(new ButtonRepresentation(new Point(251, 112), sizeSideButtons, GamepadButtonFlags.Back));

            buttons.Add(new ButtonRepresentation(new Point(193, 212), sizeHorizontalArrow, GamepadButtonFlags.DPadLeft));
            buttons.Add(new ButtonRepresentation(new Point(248, 212), sizeHorizontalArrow, GamepadButtonFlags.DPadRight));

            buttons.Add(new ButtonRepresentation(new Point(218, 186), sizeVerticalArrow, GamepadButtonFlags.DPadUp));
            buttons.Add(new ButtonRepresentation(new Point(218, 242), sizeVerticalArrow, GamepadButtonFlags.DPadDown));

            sticks.Add(new AnalogStickRepresentation(new Rectangle(123, 95, 68, 68)));
            sticks.Add(new AnalogStickRepresentation(new Rectangle(359, 191, 68, 68)));
        }
    }
}
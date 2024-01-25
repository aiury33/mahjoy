using SharpDX.XInput;

namespace mahjoy
{
    public partial class Main : Form
    {
        private const byte LEFT_STICK = 0;
        private const byte RIGHT_STICK = 1;
        private const byte TRIGGER_THRESHOLD = 10;

        private MyController myController;

        private List<ButtonRepresentation> buttons;
        private List<AnalogStickRepresentation> sticks;

        public Main()
        {
            InitializeComponent();
            InitializeControllerComponents(ref buttons, ref sticks);

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

            UpdateTriggerPressureBarsUI(myController.ControllerState.Gamepad);
        }

        private void UpdateTriggerUI(Panel panel, byte triggerValue)
        {
            bool isPressed = triggerValue > TRIGGER_THRESHOLD;
            UpdateButtonUI(panel, isPressed);
        }

        private void UpdateTriggerPressureBarsUI(Gamepad gamepad)
        {
            pb1.Value = gamepad.LeftTrigger;
            pb2.Value = gamepad.RightTrigger;
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

        private void picController_Paint(object sender, PaintEventArgs e)
        {
            PaintButtons(e);
            PaintSticks(e);
        }

        private void PaintButtons(PaintEventArgs e)
        {
            foreach (var button in buttons)
            {
                button.Draw(e.Graphics, myController.ControllerState.Gamepad.Buttons);
            }
        }

        private void PaintSticks(PaintEventArgs e)
        {
            using (SolidBrush violetBrush = new SolidBrush(Color.Violet))
            {
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
    }
}
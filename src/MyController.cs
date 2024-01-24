using SharpDX.XInput;
using Timer = System.Windows.Forms.Timer;

namespace mahjoy
{
    internal class MyController
    {
        private const int DEFAULT_INTERVAL = 50;

        internal Controller Controller { get; private set; }
        internal Timer ControllerPollingTimer { get; private set; }
        internal State ControllerState { get; set; }

        public MyController(Controller controller)
        {
            Controller = controller;
            ControllerPollingTimer = new Timer();
            ControllerPollingTimer.Interval = DEFAULT_INTERVAL;
        }
    }
}

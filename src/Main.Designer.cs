using SharpDX.XInput;

namespace mahjoy
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblHeader = new Label();
            pnlExit = new Panel();
            pnlCenter = new Panel();
            pnlR2 = new Panel();
            lblR2 = new Label();
            pnlL2 = new Panel();
            lblL2 = new Label();
            pnlL1 = new Panel();
            lblL1 = new Label();
            pnlR1 = new Panel();
            lblR1 = new Label();
            pb1 = new CustomColorProgressBar(Color.Violet);
            pb2 = new CustomColorProgressBar(Color.Violet);
            picController = new PictureBox();
            tblMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlCenter.SuspendLayout();
            pnlR2.SuspendLayout();
            pnlL2.SuspendLayout();
            pnlL1.SuspendLayout();
            pnlR1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picController).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(pnlHeader, 0, 0);
            tblMain.Controls.Add(pnlCenter, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(932, 581);
            tblMain.TabIndex = 2;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Silver;
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(pnlExit);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(932, 30);
            pnlHeader.TabIndex = 4;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(445, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(53, 15);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "mahjoy";
            // 
            // pnlExit
            // 
            pnlExit.BackColor = Color.LightCoral;
            pnlExit.Location = new Point(865, 6);
            pnlExit.Name = "pnlExit";
            pnlExit.Size = new Size(54, 13);
            pnlExit.TabIndex = 0;
            pnlExit.Click += pnlExit_Click;
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(pb2);
            pnlCenter.Controls.Add(pb1);
            pnlCenter.Controls.Add(pnlR2);
            pnlCenter.Controls.Add(pnlL2);
            pnlCenter.Controls.Add(pnlL1);
            pnlCenter.Controls.Add(pnlR1);
            pnlCenter.Controls.Add(picController);
            pnlCenter.Dock = DockStyle.Fill;
            pnlCenter.Location = new Point(0, 30);
            pnlCenter.Margin = new Padding(0);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(932, 531);
            pnlCenter.TabIndex = 5;
            // 
            // pb2
            // 
            pb2.Location = new Point(551, 9);
            pb2.Maximum = 255;
            pb2.Name = "pb2";
            pb2.Size = new Size(115, 20);
            pb2.TabIndex = 10;
            // 
            // pb1
            // 
            pb1.Location = new Point(273, 9);
            pb1.Maximum = 255;
            pb1.Name = "pb1";
            pb1.Size = new Size(115, 20);
            pb1.TabIndex = 9;
            // 
            // pnlR2
            // 
            pnlR2.BackColor = Color.Black;
            pnlR2.Controls.Add(lblR2);
            pnlR2.ForeColor = SystemColors.ButtonFace;
            pnlR2.Location = new Point(551, 35);
            pnlR2.Name = "pnlR2";
            pnlR2.Size = new Size(115, 37);
            pnlR2.TabIndex = 8;
            // 
            // lblR2
            // 
            lblR2.Dock = DockStyle.Fill;
            lblR2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblR2.Location = new Point(0, 0);
            lblR2.Name = "lblR2";
            lblR2.Size = new Size(115, 37);
            lblR2.TabIndex = 2;
            lblR2.Text = "R2";
            lblR2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlL2
            // 
            pnlL2.BackColor = Color.Black;
            pnlL2.Controls.Add(lblL2);
            pnlL2.ForeColor = SystemColors.ButtonFace;
            pnlL2.Location = new Point(273, 35);
            pnlL2.Name = "pnlL2";
            pnlL2.Size = new Size(115, 37);
            pnlL2.TabIndex = 7;
            // 
            // lblL2
            // 
            lblL2.Dock = DockStyle.Fill;
            lblL2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblL2.Location = new Point(0, 0);
            lblL2.Name = "lblL2";
            lblL2.Size = new Size(115, 37);
            lblL2.TabIndex = 2;
            lblL2.Text = "L2";
            lblL2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlL1
            // 
            pnlL1.BackColor = Color.Black;
            pnlL1.Controls.Add(lblL1);
            pnlL1.ForeColor = SystemColors.ButtonFace;
            pnlL1.Location = new Point(273, 78);
            pnlL1.Name = "pnlL1";
            pnlL1.Size = new Size(115, 22);
            pnlL1.TabIndex = 6;
            // 
            // lblL1
            // 
            lblL1.Dock = DockStyle.Fill;
            lblL1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblL1.Location = new Point(0, 0);
            lblL1.Name = "lblL1";
            lblL1.Size = new Size(115, 22);
            lblL1.TabIndex = 2;
            lblL1.Text = "L1";
            lblL1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlR1
            // 
            pnlR1.BackColor = Color.Black;
            pnlR1.Controls.Add(lblR1);
            pnlR1.ForeColor = SystemColors.ButtonFace;
            pnlR1.Location = new Point(551, 78);
            pnlR1.Name = "pnlR1";
            pnlR1.Size = new Size(115, 22);
            pnlR1.TabIndex = 5;
            // 
            // lblR1
            // 
            lblR1.Dock = DockStyle.Fill;
            lblR1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblR1.Location = new Point(0, 0);
            lblR1.Name = "lblR1";
            lblR1.Size = new Size(115, 22);
            lblR1.TabIndex = 2;
            lblR1.Text = "R1";
            lblR1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picController
            // 
            picController.Image = Properties.Resources.xboxControllerVector;
            picController.Location = new Point(161, 106);
            picController.Name = "picController";
            picController.Size = new Size(619, 422);
            picController.SizeMode = PictureBoxSizeMode.StretchImage;
            picController.TabIndex = 4;
            picController.TabStop = false;
            picController.Paint += picController_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 581);
            Controls.Add(tblMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            tblMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCenter.ResumeLayout(false);
            pnlR2.ResumeLayout(false);
            pnlL2.ResumeLayout(false);
            pnlL1.ResumeLayout(false);
            pnlR1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picController).EndInit();
            ResumeLayout(false);
        }

        private void InitializeControllerComponents(ref List<ButtonRepresentation> buttons, ref List<AnalogStickRepresentation> sticks)
        {
            Size sizeMainButtons = new Size(44, 44);
            Size sizeSideButtons = new Size(30, 30);
            Size sizeHorizontalArrow = new Size(27, 31);
            Size sizeVerticalArrow = new Size(31, 27);
            Size sizeThumb = new Size(68, 68);

            buttons = new List<ButtonRepresentation> { };
            sticks = new List<AnalogStickRepresentation> { };

            buttons.Add(new ButtonRepresentation(new Point(408, 106), sizeMainButtons, GamepadButtonFlags.X, Color.Violet));
            buttons.Add(new ButtonRepresentation(new Point(451, 149), sizeMainButtons, GamepadButtonFlags.A, Color.Violet));
            buttons.Add(new ButtonRepresentation(new Point(451, 63), sizeMainButtons, GamepadButtonFlags.Y, Color.Violet));
            buttons.Add(new ButtonRepresentation(new Point(491, 106), sizeMainButtons, GamepadButtonFlags.B, Color.Violet));

            buttons.Add(new ButtonRepresentation(new Point(343, 112), sizeSideButtons, GamepadButtonFlags.Start, Color.Violet));
            buttons.Add(new ButtonRepresentation(new Point(251, 112), sizeSideButtons, GamepadButtonFlags.Back, Color.Violet));

            buttons.Add(new ButtonRepresentation(new Point(193, 212), sizeHorizontalArrow, GamepadButtonFlags.DPadLeft, Color.Violet));
            buttons.Add(new ButtonRepresentation(new Point(248, 212), sizeHorizontalArrow, GamepadButtonFlags.DPadRight, Color.Violet));

            buttons.Add(new ButtonRepresentation(new Point(218, 186), sizeVerticalArrow, GamepadButtonFlags.DPadUp, Color.Violet));
            buttons.Add(new ButtonRepresentation(new Point(218, 242), sizeVerticalArrow, GamepadButtonFlags.DPadDown, Color.Violet));

            buttons.Add(new ButtonRepresentation(new Point(123, 95), sizeThumb, GamepadButtonFlags.LeftThumb, Color.Thistle));
            buttons.Add(new ButtonRepresentation(new Point(359, 191), sizeThumb, GamepadButtonFlags.RightThumb, Color.Thistle));

            sticks.Add(new AnalogStickRepresentation(new Rectangle(123, 95, 68, 68)));
            sticks.Add(new AnalogStickRepresentation(new Rectangle(359, 191, 68, 68)));
        }

        #endregion
        private TableLayoutPanel tblMain;
        private Panel pnlHeader;
        private Panel pnlCenter;
        private PictureBox picController;
        private Panel pnlExit;
        private Label lblHeader;
        private Panel pnlR1;
        private Label lblR1;
        private Panel pnlL1;
        private Label lblL1;
        private Panel pnlL2;
        private Label lblL2;
        private Panel pnlR2;
        private Label lblR2;
        private CustomColorProgressBar pb1;
        private CustomColorProgressBar pb2;
    }
}
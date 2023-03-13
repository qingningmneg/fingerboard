
namespace 输入速度
{
    partial class FrmUninfo : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Totalinput = new DevExpress.XtraEditors.LabelControl();
            this.Inputspeed = new DevExpress.XtraEditors.LabelControl();
            this.Totalinputs = new DevExpress.XtraEditors.LabelControl();
            this.Inputspeeds = new DevExpress.XtraEditors.LabelControl();
            this.calculation = new DevExpress.XtraEditors.SimpleButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timers = new System.Windows.Forms.Timer(this.components);
            this.Time = new DevExpress.XtraEditors.LabelControl();
            this.Setthetop = new DevExpress.XtraEditors.SimpleButton();
            this.transparency = new DevExpress.XtraEditors.SimpleButton();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.timess = new DevExpress.XtraEditors.LabelControl();
            this.TimeButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Totalinput
            // 
            this.Totalinput.Location = new System.Drawing.Point(6, 16);
            this.Totalinput.Margin = new System.Windows.Forms.Padding(2);
            this.Totalinput.Name = "Totalinput";
            this.Totalinput.Size = new System.Drawing.Size(52, 14);
            this.Totalinput.TabIndex = 0;
            this.Totalinput.Text = "输入总数:";
            // 
            // Inputspeed
            // 
            this.Inputspeed.Location = new System.Drawing.Point(144, 16);
            this.Inputspeed.Margin = new System.Windows.Forms.Padding(2);
            this.Inputspeed.Name = "Inputspeed";
            this.Inputspeed.Size = new System.Drawing.Size(52, 14);
            this.Inputspeed.TabIndex = 1;
            this.Inputspeed.Text = "输入速度:";
            // 
            // Totalinputs
            // 
            this.Totalinputs.Location = new System.Drawing.Point(76, 16);
            this.Totalinputs.Margin = new System.Windows.Forms.Padding(2);
            this.Totalinputs.Name = "Totalinputs";
            this.Totalinputs.Size = new System.Drawing.Size(57, 14);
            this.Totalinputs.TabIndex = 2;
            this.Totalinputs.Text = "emmmmm";
            // 
            // Inputspeeds
            // 
            this.Inputspeeds.Location = new System.Drawing.Point(214, 16);
            this.Inputspeeds.Margin = new System.Windows.Forms.Padding(2);
            this.Inputspeeds.Name = "Inputspeeds";
            this.Inputspeeds.Size = new System.Drawing.Size(57, 14);
            this.Inputspeeds.TabIndex = 3;
            this.Inputspeeds.Text = "emmmmm";
            // 
            // calculation
            // 
            this.calculation.Location = new System.Drawing.Point(517, 10);
            this.calculation.Margin = new System.Windows.Forms.Padding(2);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(59, 27);
            this.calculation.TabIndex = 4;
            this.calculation.Text = "开始计算";
            this.calculation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timers
            // 
            this.timers.Enabled = true;
            this.timers.Interval = 1000;
            this.timers.Tick += new System.EventHandler(this.timers_Tick);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(360, 16);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(24, 14);
            this.Time.TabIndex = 5;
            this.Time.Text = "用时";
            // 
            // Setthetop
            // 
            this.Setthetop.Location = new System.Drawing.Point(638, 10);
            this.Setthetop.Margin = new System.Windows.Forms.Padding(2);
            this.Setthetop.Name = "Setthetop";
            this.Setthetop.Size = new System.Drawing.Size(54, 27);
            this.Setthetop.TabIndex = 6;
            this.Setthetop.Text = "窗体设顶";
            this.Setthetop.Click += new System.EventHandler(this.Setthetop_Click);
            // 
            // transparency
            // 
            this.transparency.Location = new System.Drawing.Point(580, 10);
            this.transparency.Margin = new System.Windows.Forms.Padding(2);
            this.transparency.Name = "transparency";
            this.transparency.Size = new System.Drawing.Size(54, 27);
            this.transparency.TabIndex = 7;
            this.transparency.Text = "透明度";
            this.transparency.Click += new System.EventHandler(this.transparency_Click);
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(703, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 58);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(703, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 58);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(703, 0);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 58);
            // 
            // timess
            // 
            this.timess.Location = new System.Drawing.Point(305, 16);
            this.timess.Name = "timess";
            this.timess.Size = new System.Drawing.Size(52, 14);
            this.timess.TabIndex = 12;
            this.timess.Text = "使用时间:";
            // 
            // TimeButton
            // 
            this.TimeButton.Location = new System.Drawing.Point(422, 11);
            this.TimeButton.Margin = new System.Windows.Forms.Padding(2);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(91, 27);
            this.TimeButton.TabIndex = 13;
            this.TimeButton.Text = "目前状态(开始)";
            this.TimeButton.Click += new System.EventHandler(this.TimeButton_Click);
            // 
            // FrmUninfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 58);
            this.Controls.Add(this.TimeButton);
            this.Controls.Add(this.timess);
            this.Controls.Add(this.transparency);
            this.Controls.Add(this.Setthetop);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.Inputspeeds);
            this.Controls.Add(this.Totalinputs);
            this.Controls.Add(this.Inputspeed);
            this.Controls.Add(this.Totalinput);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUninfo";
            this.Text = "柠檬出品(测试打字速度)";
            this.Load += new System.EventHandler(this.FrmUninfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Totalinput;
        private DevExpress.XtraEditors.LabelControl Inputspeed;
        private DevExpress.XtraEditors.LabelControl Totalinputs;
        private DevExpress.XtraEditors.LabelControl Inputspeeds;
        private DevExpress.XtraEditors.SimpleButton calculation;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timers;
        private DevExpress.XtraEditors.LabelControl Time;
        private DevExpress.XtraEditors.SimpleButton Setthetop;
        private DevExpress.XtraEditors.SimpleButton transparency;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl timess;
        private DevExpress.XtraEditors.SimpleButton TimeButton;
    }
}

namespace TestForm
{
    partial class TestForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.drawButton = new System.Windows.Forms.Button();
            this.paintPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.scaleBar = new System.Windows.Forms.TrackBar();
            this.xOffsetBar = new System.Windows.Forms.TrackBar();
            this.yOffsetBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleTip = new System.Windows.Forms.Label();
            this.xOffsetTip = new System.Windows.Forms.Label();
            this.yOffsetTip = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.shaftButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.stepBar = new System.Windows.Forms.TrackBar();
            this.stepTip = new System.Windows.Forms.Label();
            this.autoRefreshBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.moveBar = new System.Windows.Forms.TrackBar();
            this.moveTip = new System.Windows.Forms.Label();
            this.autoStepBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveBar)).BeginInit();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawButton.Location = new System.Drawing.Point(727, 12);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Func";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawButton_MouseDown);
            // 
            // paintPanel
            // 
            this.paintPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintPanel.AutoScroll = true;
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPanel.Location = new System.Drawing.Point(12, 12);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(709, 449);
            this.paintPanel.TabIndex = 1;
            this.paintPanel.Click += new System.EventHandler(this.paintPanel_Click);
            this.paintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paintPanel_Paint);
            this.paintPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseDoubleClick);
            this.paintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseDown);
            this.paintPanel.MouseLeave += new System.EventHandler(this.paintPanel_MouseLeave);
            this.paintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseMove);
            this.paintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseUp);
            this.paintPanel.Resize += new System.EventHandler(this.paintPanel_Resize);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(889, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // scaleBar
            // 
            this.scaleBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleBar.Location = new System.Drawing.Point(727, 67);
            this.scaleBar.Maximum = 5000;
            this.scaleBar.Minimum = 1;
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(269, 45);
            this.scaleBar.TabIndex = 3;
            this.scaleBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scaleBar.Value = 1;
            // 
            // xOffsetBar
            // 
            this.xOffsetBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xOffsetBar.Location = new System.Drawing.Point(727, 130);
            this.xOffsetBar.Name = "xOffsetBar";
            this.xOffsetBar.Size = new System.Drawing.Size(269, 45);
            this.xOffsetBar.TabIndex = 4;
            this.xOffsetBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // yOffsetBar
            // 
            this.yOffsetBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yOffsetBar.Location = new System.Drawing.Point(727, 193);
            this.yOffsetBar.Name = "yOffsetBar";
            this.yOffsetBar.Size = new System.Drawing.Size(269, 45);
            this.yOffsetBar.TabIndex = 5;
            this.yOffsetBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scale";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "XOffset";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "YOffset";
            // 
            // scaleTip
            // 
            this.scaleTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleTip.AutoSize = true;
            this.scaleTip.Location = new System.Drawing.Point(961, 52);
            this.scaleTip.Name = "scaleTip";
            this.scaleTip.Size = new System.Drawing.Size(11, 12);
            this.scaleTip.TabIndex = 9;
            this.scaleTip.Text = "0";
            // 
            // xOffsetTip
            // 
            this.xOffsetTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xOffsetTip.AutoSize = true;
            this.xOffsetTip.Location = new System.Drawing.Point(961, 115);
            this.xOffsetTip.Name = "xOffsetTip";
            this.xOffsetTip.Size = new System.Drawing.Size(11, 12);
            this.xOffsetTip.TabIndex = 10;
            this.xOffsetTip.Text = "0";
            // 
            // yOffsetTip
            // 
            this.yOffsetTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yOffsetTip.AutoSize = true;
            this.yOffsetTip.Location = new System.Drawing.Point(961, 178);
            this.yOffsetTip.Name = "yOffsetTip";
            this.yOffsetTip.Size = new System.Drawing.Size(11, 12);
            this.yOffsetTip.TabIndex = 11;
            this.yOffsetTip.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(729, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shaftButton
            // 
            this.shaftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shaftButton.Location = new System.Drawing.Point(808, 12);
            this.shaftButton.Name = "shaftButton";
            this.shaftButton.Size = new System.Drawing.Size(75, 23);
            this.shaftButton.TabIndex = 13;
            this.shaftButton.Text = "Shaft";
            this.shaftButton.UseVisualStyleBackColor = true;
            this.shaftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shaftButton_MouseDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Step";
            // 
            // stepBar
            // 
            this.stepBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stepBar.Location = new System.Drawing.Point(727, 256);
            this.stepBar.Maximum = 1000;
            this.stepBar.Minimum = 1;
            this.stepBar.Name = "stepBar";
            this.stepBar.Size = new System.Drawing.Size(269, 45);
            this.stepBar.TabIndex = 15;
            this.stepBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.stepBar.Value = 1;
            // 
            // stepTip
            // 
            this.stepTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stepTip.AutoSize = true;
            this.stepTip.Location = new System.Drawing.Point(961, 241);
            this.stepTip.Name = "stepTip";
            this.stepTip.Size = new System.Drawing.Size(11, 12);
            this.stepTip.TabIndex = 16;
            this.stepTip.Text = "0";
            // 
            // autoRefreshBox
            // 
            this.autoRefreshBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.autoRefreshBox.AutoSize = true;
            this.autoRefreshBox.Checked = true;
            this.autoRefreshBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefreshBox.Location = new System.Drawing.Point(812, 442);
            this.autoRefreshBox.Name = "autoRefreshBox";
            this.autoRefreshBox.Size = new System.Drawing.Size(96, 16);
            this.autoRefreshBox.TabIndex = 17;
            this.autoRefreshBox.Text = "Auto Refresh";
            this.autoRefreshBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Math.Sin",
            "Math.Cos",
            "Math.Tan",
            "Math.Asin",
            "Math.Acos",
            "Math.Atan",
            "Math.Sinh",
            "Math.Cosh",
            "Math.Tanh",
            "Math.Sqrt",
            "Math.Log",
            "Math.Log10",
            "Math.Abs",
            "Math.Exp"});
            this.comboBox1.Location = new System.Drawing.Point(740, 330);
            this.comboBox1.MaxDropDownItems = 100;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 20);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // moveBar
            // 
            this.moveBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moveBar.Location = new System.Drawing.Point(727, 376);
            this.moveBar.Maximum = 1000;
            this.moveBar.Minimum = 1;
            this.moveBar.Name = "moveBar";
            this.moveBar.Size = new System.Drawing.Size(269, 45);
            this.moveBar.TabIndex = 19;
            this.moveBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.moveBar.Value = 1;
            // 
            // moveTip
            // 
            this.moveTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveTip.AutoSize = true;
            this.moveTip.Location = new System.Drawing.Point(961, 338);
            this.moveTip.Name = "moveTip";
            this.moveTip.Size = new System.Drawing.Size(11, 12);
            this.moveTip.TabIndex = 20;
            this.moveTip.Text = "0";
            // 
            // autoStepBox
            // 
            this.autoStepBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.autoStepBox.AutoSize = true;
            this.autoStepBox.Checked = true;
            this.autoStepBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoStepBox.Location = new System.Drawing.Point(914, 442);
            this.autoStepBox.Name = "autoStepBox";
            this.autoStepBox.Size = new System.Drawing.Size(78, 16);
            this.autoStepBox.TabIndex = 21;
            this.autoStepBox.Text = "Auto Step";
            this.autoStepBox.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.autoStepBox);
            this.Controls.Add(this.moveTip);
            this.Controls.Add(this.moveBar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.autoRefreshBox);
            this.Controls.Add(this.stepTip);
            this.Controls.Add(this.stepBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shaftButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yOffsetTip);
            this.Controls.Add(this.xOffsetTip);
            this.Controls.Add(this.scaleTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yOffsetBar);
            this.Controls.Add(this.xOffsetBar);
            this.Controls.Add(this.scaleBar);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.paintPanel);
            this.Controls.Add(this.drawButton);
            this.DoubleBuffered = true;
            this.Name = "TestForm";
            this.Text = "DrawFuncTest";
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scaleTip;
        private System.Windows.Forms.Label xOffsetTip;
        private System.Windows.Forms.Label yOffsetTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button shaftButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stepTip;
        public System.Windows.Forms.TrackBar scaleBar;
        public System.Windows.Forms.TrackBar xOffsetBar;
        public System.Windows.Forms.TrackBar yOffsetBar;
        public System.Windows.Forms.TrackBar stepBar;
        private System.Windows.Forms.CheckBox autoRefreshBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label moveTip;
        private System.Windows.Forms.TrackBar moveBar;
        private System.Windows.Forms.CheckBox autoStepBox;
    }
}


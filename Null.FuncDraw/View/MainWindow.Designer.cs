
namespace Null.FuncDraw.View
{
    partial class MainWindow
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
            this.paintPanel = new System.Windows.Forms.Panel();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.moveSignal = new Null.FuncDraw.UserControls.NTrackBar();
            this.settingsButton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.drawStep = new Null.FuncDraw.UserControls.NTrackBar();
            this.clearButton = new System.Windows.Forms.Button();
            this.shaftButton = new System.Windows.Forms.Button();
            this.funcButton = new System.Windows.Forms.Button();
            this.yOffsetBar = new Null.FuncDraw.UserControls.NTrackBar();
            this.xOffsetBar = new Null.FuncDraw.UserControls.NTrackBar();
            this.scaleBar = new Null.FuncDraw.UserControls.NTrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.optionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintPanel
            // 
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintPanel.Location = new System.Drawing.Point(0, 0);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(718, 449);
            this.paintPanel.TabIndex = 0;
            this.paintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseDown);
            this.paintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseMove);
            this.paintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseUp);
            this.paintPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseWheel);
            this.paintPanel.Resize += new System.EventHandler(this.paintPanel_Resize);
            // 
            // optionPanel
            // 
            this.optionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionPanel.Controls.Add(this.moveSignal);
            this.optionPanel.Controls.Add(this.settingsButton);
            this.optionPanel.Controls.Add(this.managerButton);
            this.optionPanel.Controls.Add(this.drawStep);
            this.optionPanel.Controls.Add(this.clearButton);
            this.optionPanel.Controls.Add(this.shaftButton);
            this.optionPanel.Controls.Add(this.funcButton);
            this.optionPanel.Controls.Add(this.yOffsetBar);
            this.optionPanel.Controls.Add(this.xOffsetBar);
            this.optionPanel.Controls.Add(this.scaleBar);
            this.optionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionPanel.Location = new System.Drawing.Point(0, 0);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(262, 449);
            this.optionPanel.TabIndex = 1;
            // 
            // moveSignal
            // 
            this.moveSignal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveSignal.Location = new System.Drawing.Point(3, 239);
            this.moveSignal.Maximum = 100;
            this.moveSignal.Minimum = -100;
            this.moveSignal.Name = "moveSignal";
            this.moveSignal.Size = new System.Drawing.Size(254, 46);
            this.moveSignal.TabIndex = 9;
            this.moveSignal.Title = "Move Signal";
            this.moveSignal.Value = 0D;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsButton.Location = new System.Drawing.Point(3, 378);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // managerButton
            // 
            this.managerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerButton.Location = new System.Drawing.Point(3, 407);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(254, 37);
            this.managerButton.TabIndex = 7;
            this.managerButton.Text = "Function Manager";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.Manager_Click);
            // 
            // drawStep
            // 
            this.drawStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawStep.Location = new System.Drawing.Point(3, 187);
            this.drawStep.Maximum = 30;
            this.drawStep.Minimum = 1;
            this.drawStep.Name = "drawStep";
            this.drawStep.Size = new System.Drawing.Size(254, 46);
            this.drawStep.TabIndex = 6;
            this.drawStep.Title = "Draw Step";
            this.drawStep.Value = 5D;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(165, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // shaftButton
            // 
            this.shaftButton.Location = new System.Drawing.Point(84, 3);
            this.shaftButton.Name = "shaftButton";
            this.shaftButton.Size = new System.Drawing.Size(75, 23);
            this.shaftButton.TabIndex = 4;
            this.shaftButton.Text = "Shaft";
            this.shaftButton.UseVisualStyleBackColor = true;
            this.shaftButton.Click += new System.EventHandler(this.shaftButton_Click);
            // 
            // funcButton
            // 
            this.funcButton.Location = new System.Drawing.Point(3, 2);
            this.funcButton.Name = "funcButton";
            this.funcButton.Size = new System.Drawing.Size(75, 23);
            this.funcButton.TabIndex = 3;
            this.funcButton.Text = "Func";
            this.funcButton.UseVisualStyleBackColor = true;
            this.funcButton.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // yOffsetBar
            // 
            this.yOffsetBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yOffsetBar.Location = new System.Drawing.Point(3, 135);
            this.yOffsetBar.Maximum = 100;
            this.yOffsetBar.Minimum = -100;
            this.yOffsetBar.Name = "yOffsetBar";
            this.yOffsetBar.Size = new System.Drawing.Size(254, 46);
            this.yOffsetBar.TabIndex = 2;
            this.yOffsetBar.Title = "Y Offset";
            this.yOffsetBar.Value = 0D;
            // 
            // xOffsetBar
            // 
            this.xOffsetBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xOffsetBar.Location = new System.Drawing.Point(3, 83);
            this.xOffsetBar.Maximum = 100;
            this.xOffsetBar.Minimum = -100;
            this.xOffsetBar.Name = "xOffsetBar";
            this.xOffsetBar.Size = new System.Drawing.Size(254, 46);
            this.xOffsetBar.TabIndex = 1;
            this.xOffsetBar.Title = "X Offset";
            this.xOffsetBar.Value = 0D;
            // 
            // scaleBar
            // 
            this.scaleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleBar.Location = new System.Drawing.Point(3, 31);
            this.scaleBar.Maximum = 9;
            this.scaleBar.Minimum = -9;
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(254, 46);
            this.scaleBar.TabIndex = 0;
            this.scaleBar.Title = "Scale";
            this.scaleBar.Value = 0D;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.paintPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.optionPanel);
            this.splitContainer1.Size = new System.Drawing.Size(984, 449);
            this.splitContainer1.SplitterDistance = 718;
            this.splitContainer1.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindow";
            this.Text = "Null.FuncDraw";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.optionPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Panel optionPanel;
        private UserControls.NTrackBar scaleBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button managerButton;
        private UserControls.NTrackBar drawStep;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button shaftButton;
        private System.Windows.Forms.Button funcButton;
        private UserControls.NTrackBar yOffsetBar;
        private UserControls.NTrackBar xOffsetBar;
        private UserControls.NTrackBar moveSignal;
    }
}


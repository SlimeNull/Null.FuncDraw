
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.paintPanel);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.optionPanel);
            // 
            // paintPanel
            // 
            resources.ApplyResources(this.paintPanel, "paintPanel");
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseDown);
            this.paintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseMove);
            this.paintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseUp);
            this.paintPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseWheel);
            this.paintPanel.Resize += new System.EventHandler(this.paintPanel_Resize);
            // 
            // optionPanel
            // 
            resources.ApplyResources(this.optionPanel, "optionPanel");
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
            this.optionPanel.Name = "optionPanel";
            // 
            // moveSignal
            // 
            resources.ApplyResources(this.moveSignal, "moveSignal");
            this.moveSignal.Maximum = 100;
            this.moveSignal.Minimum = -100;
            this.moveSignal.Name = "moveSignal";
            this.moveSignal.Title = "Move Signal";
            this.moveSignal.Value = 0D;
            // 
            // settingsButton
            // 
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // managerButton
            // 
            resources.ApplyResources(this.managerButton, "managerButton");
            this.managerButton.Name = "managerButton";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.Manager_Click);
            // 
            // drawStep
            // 
            resources.ApplyResources(this.drawStep, "drawStep");
            this.drawStep.Maximum = 30;
            this.drawStep.Minimum = 1;
            this.drawStep.Name = "drawStep";
            this.drawStep.Title = "Draw Step";
            this.drawStep.Value = 5D;
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // shaftButton
            // 
            resources.ApplyResources(this.shaftButton, "shaftButton");
            this.shaftButton.Name = "shaftButton";
            this.shaftButton.UseVisualStyleBackColor = true;
            this.shaftButton.Click += new System.EventHandler(this.shaftButton_Click);
            // 
            // funcButton
            // 
            resources.ApplyResources(this.funcButton, "funcButton");
            this.funcButton.Name = "funcButton";
            this.funcButton.UseVisualStyleBackColor = true;
            this.funcButton.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // yOffsetBar
            // 
            resources.ApplyResources(this.yOffsetBar, "yOffsetBar");
            this.yOffsetBar.Maximum = 100;
            this.yOffsetBar.Minimum = -100;
            this.yOffsetBar.Name = "yOffsetBar";
            this.yOffsetBar.Title = "Y Offset";
            this.yOffsetBar.Value = 0D;
            // 
            // xOffsetBar
            // 
            resources.ApplyResources(this.xOffsetBar, "xOffsetBar");
            this.xOffsetBar.Maximum = 100;
            this.xOffsetBar.Minimum = -100;
            this.xOffsetBar.Name = "xOffsetBar";
            this.xOffsetBar.Title = "X Offset";
            this.xOffsetBar.Value = 0D;
            // 
            // scaleBar
            // 
            resources.ApplyResources(this.scaleBar, "scaleBar");
            this.scaleBar.Maximum = 9;
            this.scaleBar.Minimum = -9;
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Title = "Scale";
            this.scaleBar.Value = 0D;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.optionPanel.ResumeLayout(false);
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


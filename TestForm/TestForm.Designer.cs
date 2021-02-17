
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
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetBar)).BeginInit();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawButton.Location = new System.Drawing.Point(713, 12);
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
            this.paintPanel.Size = new System.Drawing.Size(695, 426);
            this.paintPanel.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(875, 12);
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
            this.scaleBar.Location = new System.Drawing.Point(713, 67);
            this.scaleBar.Maximum = 50;
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(269, 45);
            this.scaleBar.TabIndex = 3;
            this.scaleBar.Value = 1;
            // 
            // xOffsetBar
            // 
            this.xOffsetBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xOffsetBar.Location = new System.Drawing.Point(713, 130);
            this.xOffsetBar.Name = "xOffsetBar";
            this.xOffsetBar.Size = new System.Drawing.Size(269, 45);
            this.xOffsetBar.TabIndex = 4;
            // 
            // yOffsetBar
            // 
            this.yOffsetBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yOffsetBar.Location = new System.Drawing.Point(713, 193);
            this.yOffsetBar.Name = "yOffsetBar";
            this.yOffsetBar.Size = new System.Drawing.Size(269, 45);
            this.yOffsetBar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scale";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "XOffset";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "YOffset";
            // 
            // scaleTip
            // 
            this.scaleTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleTip.AutoSize = true;
            this.scaleTip.Location = new System.Drawing.Point(947, 52);
            this.scaleTip.Name = "scaleTip";
            this.scaleTip.Size = new System.Drawing.Size(11, 12);
            this.scaleTip.TabIndex = 9;
            this.scaleTip.Text = "0";
            // 
            // xOffsetTip
            // 
            this.xOffsetTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xOffsetTip.AutoSize = true;
            this.xOffsetTip.Location = new System.Drawing.Point(947, 115);
            this.xOffsetTip.Name = "xOffsetTip";
            this.xOffsetTip.Size = new System.Drawing.Size(11, 12);
            this.xOffsetTip.TabIndex = 10;
            this.xOffsetTip.Text = "0";
            // 
            // yOffsetTip
            // 
            this.yOffsetTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yOffsetTip.AutoSize = true;
            this.yOffsetTip.Location = new System.Drawing.Point(947, 178);
            this.yOffsetTip.Name = "yOffsetTip";
            this.yOffsetTip.Size = new System.Drawing.Size(11, 12);
            this.yOffsetTip.TabIndex = 11;
            this.yOffsetTip.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(715, 415);
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
            this.shaftButton.Location = new System.Drawing.Point(794, 12);
            this.shaftButton.Name = "shaftButton";
            this.shaftButton.Size = new System.Drawing.Size(75, 23);
            this.shaftButton.TabIndex = 13;
            this.shaftButton.Text = "Shaft";
            this.shaftButton.UseVisualStyleBackColor = true;
            this.shaftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shaftButton_MouseDown);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
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
            this.Name = "TestForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TrackBar scaleBar;
        private System.Windows.Forms.TrackBar xOffsetBar;
        private System.Windows.Forms.TrackBar yOffsetBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scaleTip;
        private System.Windows.Forms.Label xOffsetTip;
        private System.Windows.Forms.Label yOffsetTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button shaftButton;
    }
}


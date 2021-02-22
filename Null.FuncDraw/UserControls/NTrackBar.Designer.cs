
namespace Null.FuncDraw.UserControls
{
    partial class NTrackBar
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTrackBar = new System.Windows.Forms.TrackBar();
            this.textLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTrackBar
            // 
            this.mainTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTrackBar.Location = new System.Drawing.Point(3, 18);
            this.mainTrackBar.Name = "mainTrackBar";
            this.mainTrackBar.Size = new System.Drawing.Size(144, 45);
            this.mainTrackBar.TabIndex = 0;
            this.mainTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(3, 3);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(29, 12);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Text";
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valueLabel.Location = new System.Drawing.Point(67, 3);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(74, 12);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "Value";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.mainTrackBar);
            this.Name = "NTrackBar";
            this.Size = new System.Drawing.Size(150, 46);
            ((System.ComponentModel.ISupportInitialize)(this.mainTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar mainTrackBar;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label valueLabel;
    }
}

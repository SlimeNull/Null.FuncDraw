
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NTrackBar));
            this.mainTrackBar = new System.Windows.Forms.TrackBar();
            this.textLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTrackBar
            // 
            resources.ApplyResources(this.mainTrackBar, "mainTrackBar");
            this.mainTrackBar.Name = "mainTrackBar";
            this.mainTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // textLabel
            // 
            resources.ApplyResources(this.textLabel, "textLabel");
            this.textLabel.Name = "textLabel";
            // 
            // valueLabel
            // 
            resources.ApplyResources(this.valueLabel, "valueLabel");
            this.valueLabel.Name = "valueLabel";
            // 
            // NTrackBar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.mainTrackBar);
            this.Name = "NTrackBar";
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

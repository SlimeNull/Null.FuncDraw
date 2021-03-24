
namespace Null.FuncDraw.View
{
    partial class FunctionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionManager));
            this.functionList = new System.Windows.Forms.ListBox();
            this.close = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.append = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // functionList
            // 
            resources.ApplyResources(this.functionList, "functionList");
            this.functionList.FormattingEnabled = true;
            this.functionList.Name = "functionList";
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.Name = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // remove
            // 
            resources.ApplyResources(this.remove, "remove");
            this.remove.Name = "remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // append
            // 
            resources.ApplyResources(this.append, "append");
            this.append.Name = "append";
            this.append.UseVisualStyleBackColor = true;
            this.append.Click += new System.EventHandler(this.append_Click);
            // 
            // modify
            // 
            resources.ApplyResources(this.modify, "modify");
            this.modify.Name = "modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // accept
            // 
            resources.ApplyResources(this.accept, "accept");
            this.accept.Name = "accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // FunctionManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accept);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.append);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.close);
            this.Controls.Add(this.functionList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FunctionManager";
            this.Load += new System.EventHandler(this.FunctionManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox functionList;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button append;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button accept;
    }
}
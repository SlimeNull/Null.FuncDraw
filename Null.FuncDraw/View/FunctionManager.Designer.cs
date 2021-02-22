
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
            this.functionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionList.FormattingEnabled = true;
            this.functionList.ItemHeight = 12;
            this.functionList.Location = new System.Drawing.Point(12, 12);
            this.functionList.Name = "functionList";
            this.functionList.Size = new System.Drawing.Size(329, 448);
            this.functionList.TabIndex = 0;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(347, 408);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.Location = new System.Drawing.Point(347, 379);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 2;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // append
            // 
            this.append.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.append.Location = new System.Drawing.Point(347, 321);
            this.append.Name = "append";
            this.append.Size = new System.Drawing.Size(75, 23);
            this.append.TabIndex = 5;
            this.append.Text = "Append";
            this.append.UseVisualStyleBackColor = true;
            this.append.Click += new System.EventHandler(this.append_Click);
            // 
            // modify
            // 
            this.modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modify.Location = new System.Drawing.Point(347, 350);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(75, 23);
            this.modify.TabIndex = 6;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(347, 437);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 14;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // FunctionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 473);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.append);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.close);
            this.Controls.Add(this.functionList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FunctionManager";
            this.Text = "FunctionManager";
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
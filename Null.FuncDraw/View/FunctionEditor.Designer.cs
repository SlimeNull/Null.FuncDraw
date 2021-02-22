
namespace Null.FuncDraw.View
{
    partial class FunctionEditor
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
            this.append = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.operationList = new System.Windows.Forms.ListBox();
            this.modify = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // append
            // 
            this.append.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.append.Location = new System.Drawing.Point(347, 262);
            this.append.Name = "append";
            this.append.Size = new System.Drawing.Size(75, 23);
            this.append.TabIndex = 11;
            this.append.Text = "Append";
            this.append.UseVisualStyleBackColor = true;
            this.append.Click += new System.EventHandler(this.append_Click);
            // 
            // moveUp
            // 
            this.moveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moveUp.Location = new System.Drawing.Point(347, 320);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(75, 23);
            this.moveUp.TabIndex = 10;
            this.moveUp.Text = "Up";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDown.Location = new System.Drawing.Point(347, 349);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(75, 23);
            this.moveDown.TabIndex = 9;
            this.moveDown.Text = "Down";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.Location = new System.Drawing.Point(347, 378);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 8;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(347, 407);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 7;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // operationList
            // 
            this.operationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationList.FormattingEnabled = true;
            this.operationList.ItemHeight = 12;
            this.operationList.Location = new System.Drawing.Point(12, 12);
            this.operationList.Name = "operationList";
            this.operationList.Size = new System.Drawing.Size(329, 448);
            this.operationList.TabIndex = 6;
            // 
            // modify
            // 
            this.modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modify.Location = new System.Drawing.Point(347, 291);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(75, 23);
            this.modify.TabIndex = 12;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(347, 436);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 13;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPanel.Location = new System.Drawing.Point(347, 223);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(75, 24);
            this.colorPanel.TabIndex = 14;
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // FunctionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 473);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.append);
            this.Controls.Add(this.moveUp);
            this.Controls.Add(this.moveDown);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.close);
            this.Controls.Add(this.operationList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FunctionEditor";
            this.Text = "Edit Function";
            this.Load += new System.EventHandler(this.FunctionEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button append;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListBox operationList;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Panel colorPanel;
    }
}
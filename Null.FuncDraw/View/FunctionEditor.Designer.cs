
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionEditor));
            this.append = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.operationList = new System.Windows.Forms.ListBox();
            this.modify = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.funcNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // append
            // 
            resources.ApplyResources(this.append, "append");
            this.append.Name = "append";
            this.append.UseVisualStyleBackColor = true;
            this.append.Click += new System.EventHandler(this.append_Click);
            // 
            // moveUp
            // 
            resources.ApplyResources(this.moveUp, "moveUp");
            this.moveUp.Name = "moveUp";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            resources.ApplyResources(this.moveDown, "moveDown");
            this.moveDown.Name = "moveDown";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // remove
            // 
            resources.ApplyResources(this.remove, "remove");
            this.remove.Name = "remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.Name = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // operationList
            // 
            resources.ApplyResources(this.operationList, "operationList");
            this.operationList.FormattingEnabled = true;
            this.operationList.Name = "operationList";
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
            // colorPanel
            // 
            resources.ApplyResources(this.colorPanel, "colorPanel");
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // funcNameBox
            // 
            resources.ApplyResources(this.funcNameBox, "funcNameBox");
            this.funcNameBox.Name = "funcNameBox";
            // 
            // FunctionEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.funcNameBox);
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
            this.Load += new System.EventHandler(this.FunctionEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox funcNameBox;
    }
}
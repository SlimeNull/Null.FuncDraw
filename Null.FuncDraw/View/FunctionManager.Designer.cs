
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
            this.useExpr = new System.Windows.Forms.CheckBox();
            this.exprInputPn = new System.Windows.Forms.Panel();
            this.exprColorPn = new System.Windows.Forms.Panel();
            this.exprFuncNameInputTip = new System.Windows.Forms.Label();
            this.exprFuncNameInputBox = new System.Windows.Forms.TextBox();
            this.exprInputBox = new System.Windows.Forms.TextBox();
            this.exprInputCancel = new System.Windows.Forms.Button();
            this.exprInputOk = new System.Windows.Forms.Button();
            this.exprInputPn.SuspendLayout();
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
            // useExpr
            // 
            resources.ApplyResources(this.useExpr, "useExpr");
            this.useExpr.Checked = true;
            this.useExpr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useExpr.Name = "useExpr";
            this.useExpr.UseVisualStyleBackColor = true;
            // 
            // exprInputPn
            // 
            this.exprInputPn.Controls.Add(this.exprColorPn);
            this.exprInputPn.Controls.Add(this.exprFuncNameInputTip);
            this.exprInputPn.Controls.Add(this.exprFuncNameInputBox);
            this.exprInputPn.Controls.Add(this.exprInputBox);
            this.exprInputPn.Controls.Add(this.exprInputCancel);
            this.exprInputPn.Controls.Add(this.exprInputOk);
            resources.ApplyResources(this.exprInputPn, "exprInputPn");
            this.exprInputPn.Name = "exprInputPn";
            this.exprInputPn.VisibleChanged += new System.EventHandler(this.exprInputPn_VisibleChanged);
            // 
            // exprColorPn
            // 
            resources.ApplyResources(this.exprColorPn, "exprColorPn");
            this.exprColorPn.Name = "exprColorPn";
            this.exprColorPn.Click += new System.EventHandler(this.exprColorPn_Click);
            // 
            // exprFuncNameInputTip
            // 
            resources.ApplyResources(this.exprFuncNameInputTip, "exprFuncNameInputTip");
            this.exprFuncNameInputTip.BackColor = System.Drawing.SystemColors.Window;
            this.exprFuncNameInputTip.Name = "exprFuncNameInputTip";
            // 
            // exprFuncNameInputBox
            // 
            resources.ApplyResources(this.exprFuncNameInputBox, "exprFuncNameInputBox");
            this.exprFuncNameInputBox.Name = "exprFuncNameInputBox";
            this.exprFuncNameInputBox.TextChanged += new System.EventHandler(this.exprFuncNameInputBox_TextChanged);
            // 
            // exprInputBox
            // 
            resources.ApplyResources(this.exprInputBox, "exprInputBox");
            this.exprInputBox.Name = "exprInputBox";
            // 
            // exprInputCancel
            // 
            resources.ApplyResources(this.exprInputCancel, "exprInputCancel");
            this.exprInputCancel.Name = "exprInputCancel";
            this.exprInputCancel.UseVisualStyleBackColor = true;
            this.exprInputCancel.Click += new System.EventHandler(this.exprInputCancel_Click);
            // 
            // exprInputOk
            // 
            resources.ApplyResources(this.exprInputOk, "exprInputOk");
            this.exprInputOk.Name = "exprInputOk";
            this.exprInputOk.UseVisualStyleBackColor = true;
            this.exprInputOk.Click += new System.EventHandler(this.exprInputOk_Click);
            // 
            // FunctionManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exprInputPn);
            this.Controls.Add(this.useExpr);
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
            this.exprInputPn.ResumeLayout(false);
            this.exprInputPn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox functionList;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button append;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button accept;
        private CheckBox useExpr;
        private Panel exprInputPn;
        private Label exprFuncNameInputTip;
        private TextBox exprFuncNameInputBox;
        private TextBox exprInputBox;
        private Button exprInputCancel;
        private Button exprInputOk;
        private Panel exprColorPn;
    }
}
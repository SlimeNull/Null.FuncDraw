
namespace Null.FuncDraw.View
{
    partial class SubOperationEditor
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
            this.mainParamsGroup = new System.Windows.Forms.GroupBox();
            this.mainFromConstant = new System.Windows.Forms.RadioButton();
            this.mainParamBox = new System.Windows.Forms.TextBox();
            this.mainFromVariable = new System.Windows.Forms.RadioButton();
            this.mainFromLast = new System.Windows.Forms.RadioButton();
            this.paramGroup = new System.Windows.Forms.GroupBox();
            this.viceFromConstant = new System.Windows.Forms.RadioButton();
            this.viceFromVariable = new System.Windows.Forms.RadioButton();
            this.viceFromLast = new System.Windows.Forms.RadioButton();
            this.viceParamBox = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.actionGroup = new System.Windows.Forms.GroupBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.actionTypeBox = new System.Windows.Forms.ComboBox();
            this.detailesLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.mainParamsGroup.SuspendLayout();
            this.paramGroup.SuspendLayout();
            this.actionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainParamsGroup
            // 
            this.mainParamsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainParamsGroup.Controls.Add(this.mainFromConstant);
            this.mainParamsGroup.Controls.Add(this.mainParamBox);
            this.mainParamsGroup.Controls.Add(this.mainFromVariable);
            this.mainParamsGroup.Controls.Add(this.mainFromLast);
            this.mainParamsGroup.Location = new System.Drawing.Point(12, 189);
            this.mainParamsGroup.Name = "mainParamsGroup";
            this.mainParamsGroup.Size = new System.Drawing.Size(380, 117);
            this.mainParamsGroup.TabIndex = 0;
            this.mainParamsGroup.TabStop = false;
            this.mainParamsGroup.Text = "Main Parameter";
            // 
            // mainFromConstant
            // 
            this.mainFromConstant.AutoSize = true;
            this.mainFromConstant.Location = new System.Drawing.Point(138, 52);
            this.mainFromConstant.Name = "mainFromConstant";
            this.mainFromConstant.Size = new System.Drawing.Size(101, 16);
            this.mainFromConstant.TabIndex = 3;
            this.mainFromConstant.Text = "From Constant";
            this.mainFromConstant.UseVisualStyleBackColor = true;
            this.mainFromConstant.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // mainParamBox
            // 
            this.mainParamBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainParamBox.Enabled = false;
            this.mainParamBox.Location = new System.Drawing.Point(20, 82);
            this.mainParamBox.Name = "mainParamBox";
            this.mainParamBox.Size = new System.Drawing.Size(339, 21);
            this.mainParamBox.TabIndex = 2;
            // 
            // mainFromVariable
            // 
            this.mainFromVariable.AutoSize = true;
            this.mainFromVariable.Location = new System.Drawing.Point(20, 52);
            this.mainFromVariable.Name = "mainFromVariable";
            this.mainFromVariable.Size = new System.Drawing.Size(101, 16);
            this.mainFromVariable.TabIndex = 1;
            this.mainFromVariable.Text = "From Variable";
            this.mainFromVariable.UseVisualStyleBackColor = true;
            this.mainFromVariable.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // mainFromLast
            // 
            this.mainFromLast.AutoSize = true;
            this.mainFromLast.Checked = true;
            this.mainFromLast.Location = new System.Drawing.Point(20, 25);
            this.mainFromLast.Name = "mainFromLast";
            this.mainFromLast.Size = new System.Drawing.Size(179, 16);
            this.mainFromLast.TabIndex = 0;
            this.mainFromLast.TabStop = true;
            this.mainFromLast.Text = "From Last Operation Result";
            this.mainFromLast.UseVisualStyleBackColor = true;
            // 
            // paramGroup
            // 
            this.paramGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramGroup.Controls.Add(this.viceFromConstant);
            this.paramGroup.Controls.Add(this.viceFromVariable);
            this.paramGroup.Controls.Add(this.viceFromLast);
            this.paramGroup.Controls.Add(this.viceParamBox);
            this.paramGroup.Location = new System.Drawing.Point(12, 315);
            this.paramGroup.Name = "paramGroup";
            this.paramGroup.Size = new System.Drawing.Size(380, 117);
            this.paramGroup.TabIndex = 1;
            this.paramGroup.TabStop = false;
            this.paramGroup.Text = "Vice Parameter";
            // 
            // viceFromConstant
            // 
            this.viceFromConstant.AutoSize = true;
            this.viceFromConstant.Location = new System.Drawing.Point(138, 52);
            this.viceFromConstant.Name = "viceFromConstant";
            this.viceFromConstant.Size = new System.Drawing.Size(101, 16);
            this.viceFromConstant.TabIndex = 4;
            this.viceFromConstant.Text = "From Constant";
            this.viceFromConstant.UseVisualStyleBackColor = true;
            this.viceFromConstant.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // viceFromVariable
            // 
            this.viceFromVariable.AutoSize = true;
            this.viceFromVariable.Location = new System.Drawing.Point(20, 52);
            this.viceFromVariable.Name = "viceFromVariable";
            this.viceFromVariable.Size = new System.Drawing.Size(101, 16);
            this.viceFromVariable.TabIndex = 4;
            this.viceFromVariable.Text = "From Variable";
            this.viceFromVariable.UseVisualStyleBackColor = true;
            this.viceFromVariable.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // viceFromLast
            // 
            this.viceFromLast.AutoSize = true;
            this.viceFromLast.Checked = true;
            this.viceFromLast.Location = new System.Drawing.Point(20, 25);
            this.viceFromLast.Name = "viceFromLast";
            this.viceFromLast.Size = new System.Drawing.Size(179, 16);
            this.viceFromLast.TabIndex = 4;
            this.viceFromLast.TabStop = true;
            this.viceFromLast.Text = "From Last Operation Result";
            this.viceFromLast.UseVisualStyleBackColor = true;
            // 
            // viceParamBox
            // 
            this.viceParamBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viceParamBox.Enabled = false;
            this.viceParamBox.Location = new System.Drawing.Point(20, 82);
            this.viceParamBox.Name = "viceParamBox";
            this.viceParamBox.Size = new System.Drawing.Size(339, 21);
            this.viceParamBox.TabIndex = 0;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(317, 438);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 2;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(236, 438);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // actionGroup
            // 
            this.actionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionGroup.Controls.Add(this.descriptionBox);
            this.actionGroup.Controls.Add(this.actionTypeBox);
            this.actionGroup.Controls.Add(this.detailesLabel);
            this.actionGroup.Controls.Add(this.typeLabel);
            this.actionGroup.Location = new System.Drawing.Point(12, 12);
            this.actionGroup.Name = "actionGroup";
            this.actionGroup.Size = new System.Drawing.Size(380, 171);
            this.actionGroup.TabIndex = 4;
            this.actionGroup.TabStop = false;
            this.actionGroup.Text = "Action";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionBox.Location = new System.Drawing.Point(30, 72);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(320, 80);
            this.descriptionBox.TabIndex = 3;
            // 
            // actionTypeBox
            // 
            this.actionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionTypeBox.FormattingEnabled = true;
            this.actionTypeBox.Location = new System.Drawing.Point(128, 19);
            this.actionTypeBox.Name = "actionTypeBox";
            this.actionTypeBox.Size = new System.Drawing.Size(231, 20);
            this.actionTypeBox.TabIndex = 2;
            this.actionTypeBox.SelectedIndexChanged += new System.EventHandler(this.actionTypeBox_SelectedIndexChanged);
            // 
            // detailesLabel
            // 
            this.detailesLabel.AutoSize = true;
            this.detailesLabel.Location = new System.Drawing.Point(18, 48);
            this.detailesLabel.Name = "detailesLabel";
            this.detailesLabel.Size = new System.Drawing.Size(53, 12);
            this.detailesLabel.TabIndex = 1;
            this.detailesLabel.Text = "Details:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(18, 22);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(35, 12);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type:";
            // 
            // SubOperationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 473);
            this.Controls.Add(this.actionGroup);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.paramGroup);
            this.Controls.Add(this.mainParamsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubOperationEditor";
            this.Text = "Edit Sub Operation";
            this.Load += new System.EventHandler(this.SubOperationEditor_Load);
            this.mainParamsGroup.ResumeLayout(false);
            this.mainParamsGroup.PerformLayout();
            this.paramGroup.ResumeLayout(false);
            this.paramGroup.PerformLayout();
            this.actionGroup.ResumeLayout(false);
            this.actionGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainParamsGroup;
        public System.Windows.Forms.TextBox mainParamBox;
        public System.Windows.Forms.RadioButton mainFromVariable;
        public System.Windows.Forms.RadioButton mainFromLast;
        private System.Windows.Forms.GroupBox paramGroup;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox actionGroup;
        private System.Windows.Forms.ComboBox actionTypeBox;
        private System.Windows.Forms.Label detailesLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox viceParamBox;
        private System.Windows.Forms.TextBox descriptionBox;
        public System.Windows.Forms.RadioButton mainFromConstant;
        public System.Windows.Forms.RadioButton viceFromConstant;
        public System.Windows.Forms.RadioButton viceFromVariable;
        public System.Windows.Forms.RadioButton viceFromLast;
    }
}
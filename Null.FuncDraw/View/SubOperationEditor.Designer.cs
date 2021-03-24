
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubOperationEditor));
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
            resources.ApplyResources(this.mainParamsGroup, "mainParamsGroup");
            this.mainParamsGroup.Controls.Add(this.mainFromConstant);
            this.mainParamsGroup.Controls.Add(this.mainParamBox);
            this.mainParamsGroup.Controls.Add(this.mainFromVariable);
            this.mainParamsGroup.Controls.Add(this.mainFromLast);
            this.mainParamsGroup.Name = "mainParamsGroup";
            this.mainParamsGroup.TabStop = false;
            // 
            // mainFromConstant
            // 
            resources.ApplyResources(this.mainFromConstant, "mainFromConstant");
            this.mainFromConstant.Name = "mainFromConstant";
            this.mainFromConstant.UseVisualStyleBackColor = true;
            this.mainFromConstant.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // mainParamBox
            // 
            resources.ApplyResources(this.mainParamBox, "mainParamBox");
            this.mainParamBox.Name = "mainParamBox";
            // 
            // mainFromVariable
            // 
            resources.ApplyResources(this.mainFromVariable, "mainFromVariable");
            this.mainFromVariable.Name = "mainFromVariable";
            this.mainFromVariable.UseVisualStyleBackColor = true;
            this.mainFromVariable.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // mainFromLast
            // 
            resources.ApplyResources(this.mainFromLast, "mainFromLast");
            this.mainFromLast.Checked = true;
            this.mainFromLast.Name = "mainFromLast";
            this.mainFromLast.TabStop = true;
            this.mainFromLast.UseVisualStyleBackColor = true;
            // 
            // paramGroup
            // 
            resources.ApplyResources(this.paramGroup, "paramGroup");
            this.paramGroup.Controls.Add(this.viceFromConstant);
            this.paramGroup.Controls.Add(this.viceFromVariable);
            this.paramGroup.Controls.Add(this.viceFromLast);
            this.paramGroup.Controls.Add(this.viceParamBox);
            this.paramGroup.Name = "paramGroup";
            this.paramGroup.TabStop = false;
            // 
            // viceFromConstant
            // 
            resources.ApplyResources(this.viceFromConstant, "viceFromConstant");
            this.viceFromConstant.Name = "viceFromConstant";
            this.viceFromConstant.UseVisualStyleBackColor = true;
            this.viceFromConstant.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // viceFromVariable
            // 
            resources.ApplyResources(this.viceFromVariable, "viceFromVariable");
            this.viceFromVariable.Name = "viceFromVariable";
            this.viceFromVariable.UseVisualStyleBackColor = true;
            this.viceFromVariable.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // viceFromLast
            // 
            resources.ApplyResources(this.viceFromLast, "viceFromLast");
            this.viceFromLast.Checked = true;
            this.viceFromLast.Name = "viceFromLast";
            this.viceFromLast.TabStop = true;
            this.viceFromLast.UseVisualStyleBackColor = true;
            // 
            // viceParamBox
            // 
            resources.ApplyResources(this.viceParamBox, "viceParamBox");
            this.viceParamBox.Name = "viceParamBox";
            // 
            // accept
            // 
            resources.ApplyResources(this.accept, "accept");
            this.accept.Name = "accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // cancel
            // 
            resources.ApplyResources(this.cancel, "cancel");
            this.cancel.Name = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // actionGroup
            // 
            resources.ApplyResources(this.actionGroup, "actionGroup");
            this.actionGroup.Controls.Add(this.descriptionBox);
            this.actionGroup.Controls.Add(this.actionTypeBox);
            this.actionGroup.Controls.Add(this.detailesLabel);
            this.actionGroup.Controls.Add(this.typeLabel);
            this.actionGroup.Name = "actionGroup";
            this.actionGroup.TabStop = false;
            // 
            // descriptionBox
            // 
            resources.ApplyResources(this.descriptionBox, "descriptionBox");
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            // 
            // actionTypeBox
            // 
            resources.ApplyResources(this.actionTypeBox, "actionTypeBox");
            this.actionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionTypeBox.FormattingEnabled = true;
            this.actionTypeBox.Name = "actionTypeBox";
            this.actionTypeBox.SelectedIndexChanged += new System.EventHandler(this.actionTypeBox_SelectedIndexChanged);
            // 
            // detailesLabel
            // 
            resources.ApplyResources(this.detailesLabel, "detailesLabel");
            this.detailesLabel.Name = "detailesLabel";
            // 
            // typeLabel
            // 
            resources.ApplyResources(this.typeLabel, "typeLabel");
            this.typeLabel.Name = "typeLabel";
            // 
            // SubOperationEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actionGroup);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.paramGroup);
            this.Controls.Add(this.mainParamsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubOperationEditor";
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
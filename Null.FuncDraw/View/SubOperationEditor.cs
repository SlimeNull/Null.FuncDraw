using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Null.FuncDraw.Model;

namespace Null.FuncDraw.View
{
    public partial class SubOperationEditor : Form
    {
        private string[] actionTexts = new string[]
        {
            "ModifyValue",

            "PlusOperation",
            "MinusOperation",
            "MulOperation",
            "DivOperation",
            
            "SinOperation",
            "CosOperation",
            "TanOperation",

            "AsinOperation",
            "AcosOperation",
            "AtanOperation",

            "SinhOperation",
            "CoshOperation",
            "TanhOperation",
            
            "PowOperation",
            "LogOperation",
        };
        public SubOperationEditor(Form parent)
        {
            InitializeComponent();

            this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2, parent.Top + (parent.Height - this.Height) / 2);
            this.Shown += (sender, e) => this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2, parent.Top + (parent.Height - this.Height) / 2);

            actionTypeBox.Items.AddRange(actionTexts);
        }

        public ISubOperation SubOperation { get; set; }



        private void Accept_Click(object sender, EventArgs e)
        {
            SubOperationOption option = new SubOperationOption()
            {
                OperationName = actionTypeBox.Text,
                MainParamSource = mainParamBox.Text,
                ViceParamSource = viceParamBox.Text,
            };

            if (mainFromLast.Checked)
                option.MainParamType = SOParamType.FromLast;
            else if (mainFromVariable.Checked)
                option.MainParamType = SOParamType.FromVariable;
            else if (mainFromConstant.Checked)
                option.MainParamType = SOParamType.FromConstant;
            else
                option.MainParamType = SOParamType.FromLast;

            if (viceFromLast.Checked)
                option.ViceParamType = SOParamType.FromLast;
            else if (viceFromVariable.Checked)
                option.ViceParamType = SOParamType.FromVariable;
            else if (viceFromConstant.Checked)
                option.ViceParamType = SOParamType.FromConstant;
            else
                option.ViceParamType = SOParamType.FromLast;

            SubOperation = SubOperationManager.GetSubOperationInstance(option);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubOperationEditor_Load(object sender, EventArgs e)
        {
            if (SubOperation != null)
            {
                Type optType = SubOperation.GetType();
                string typeText = SubOperationManager.GetSubOperationName(optType);
                actionTypeBox.SelectedIndex = Array.IndexOf(actionTexts, typeText);

                switch (SubOperation.MainParamType)
                {
                    case SOParamType.FromLast:
                        mainFromLast.Checked = true;
                        break;
                    case SOParamType.FromVariable:
                        mainFromVariable.Checked = true;
                        break;
                    case SOParamType.FromConstant:
                        mainFromConstant.Checked = true;
                        break;
                    default:
                        mainFromLast.Checked = true;
                        break;
                }

                switch (SubOperation.ViceParamType)
                {
                    case SOParamType.FromLast:
                        viceFromLast.Checked = true;
                        break;
                    case SOParamType.FromVariable:
                        viceFromVariable.Checked = true;
                        break;
                    case SOParamType.FromConstant:
                        viceFromConstant.Checked = true;
                        break;
                    default:
                        viceFromLast.Checked = true;
                        break;
                }

                mainParamBox.Text = SubOperation.MainParamSource;
                viceParamBox.Text = SubOperation.ViceParamSource;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mainParamBox.Enabled = mainFromVariable.Checked || mainFromConstant.Checked;
            viceParamBox.Enabled = viceFromVariable.Checked || viceFromConstant.Checked;
        }

        private void actionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            descriptionBox.Text = SubOperationManager.GetOperationDescription(actionTypeBox.Text);
        }
    }
}

using Null.FuncDraw.Model;
using Null.FuncDraw.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Null.FuncDraw.View
{
    public partial class FunctionManager : Form
    {
        public FunctionManager(Form parent)
        {
            InitializeComponent();

            this.Location = new Point(parent.Left + parent.Width - this.Width - 50, parent.Top + (parent.Height - this.Height) / 2);
            this.Shown += (sender, e) => this.Location = new Point(parent.Left + parent.Width - this.Width - 50, parent.Top + (parent.Height - this.Height) / 2);
        }

        int strExprEditIndex = -1;
        public CalcFunctionBase[] Functions { get => functionList.Items.OfType<CalcFunctionBase>().ToArray(); }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int index = functionList.SelectedIndex;
            if (index >= 0)
            {
                functionList.Items.RemoveAt(index);
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            int index = functionList.SelectedIndex;
            var items = functionList.Items;
            if (index >= 0)
            {
                var func = functionList.SelectedItem;
                if (func is StrExprCalcFunction strExprFunc)
                {
                    strExprEditIndex = functionList.SelectedIndex;
                    exprInputPn.Visible = true;

                    exprFuncNameInputBox.Text = strExprFunc.FunctionName;
                    exprInputBox.Text = strExprFunc.Expression;
                    exprColorPn.BackColor = strExprFunc.ForeCore;
                }
                else if (func is ChainOptCalcFunction chainOptFunc)
                {
                    FunctionEditor editor = new FunctionEditor(this) { Function = items[index] as ChainOptCalcFunction };

                    if (editor.ShowDialog() == DialogResult.OK)
                    {
                        items[index] = editor.Function;
                    }
                }
            }
        }

        private void append_Click(object sender, EventArgs e)
        {
            FunctionEditor editor = new FunctionEditor(this);

            if (useExpr.Checked)
            {
                exprInputPn.Visible = true;
            }
            else
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    functionList.Items.Add(editor.Function);
                }
            }
        }

        private void FunctionManager_Load(object sender, EventArgs e)
        {

        }

        private void exprInputOk_Click(object sender, EventArgs e)
        {
            if (strExprEditIndex >= 0 && strExprEditIndex < functionList.Items.Count)
            {
                int index = functionList.SelectedIndex;
                var items = functionList.Items;
                var result = string.IsNullOrEmpty(exprFuncNameInputBox.Text) ?
                    new StrExprCalcFunction(exprInputBox.Text) :
                    new StrExprCalcFunction(exprFuncNameInputBox.Text, exprInputBox.Text);
                result.ForeCore = exprColorPn.BackColor;

                items[index] = result;
            }
            else
            {
                var result = string.IsNullOrEmpty(exprFuncNameInputBox.Text) ?
                    new StrExprCalcFunction(exprInputBox.Text) :
                    new StrExprCalcFunction(exprFuncNameInputBox.Text, exprInputBox.Text);
                result.ForeCore = exprColorPn.BackColor;

                functionList.Items.Add(result);

            }

            exprInputPn.Visible = false;
            strExprEditIndex = -1;
        }

        private void exprFuncNameInputBox_TextChanged(object sender, EventArgs e)
        {
            exprFuncNameInputTip.Visible = string.IsNullOrEmpty(exprFuncNameInputBox.Text);
        }

        private void exprInputCancel_Click(object sender, EventArgs e)
        {
            exprInputPn.Visible = false;
        }

        private void exprColorPn_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog()
            {
                CustomColors = new Color[] {
                    Color.FromArgb(0, 0, 0),          // 黑
                    Color.FromArgb(127, 127, 127),    // 灰
                    Color.FromArgb(237, 28, 36),      // 棕深红
                    Color.FromArgb(255, 127, 39),     // 棕橙
                    Color.FromArgb(255, 242, 0),      // 黄
                    Color.FromArgb(34, 177, 76),      // 绿
                    Color.FromArgb(0, 162, 232),      // 蓝
                    Color.FromArgb(63, 72, 204),      // 深紫
                    Color.FromArgb(163, 73, 164),     // 紫色
                    Color.FromArgb(255, 174, 201),
                    Color.FromArgb(252, 4, 156),
                    Color.FromArgb(254, 243, 223),
                    Color.FromArgb(95, 202, 210),
                    Color.FromArgb(247, 99, 165),
                    Color.FromArgb(0, 215, 175),
                    Color.FromArgb(176, 254, 230),
                }.Select((v) => ColorUtil.Color2Int(v)).ToArray(),

                FullOpen = true,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
                exprColorPn.BackColor = dialog.Color;
        }

        private void exprInputPn_VisibleChanged(object sender, EventArgs e)
        {
            exprColorPn.BackColor = Color.FromArgb(NumUtil.RandomInt(0, 200), NumUtil.RandomInt(0, 200), NumUtil.RandomInt(0, 200));
        }
    }
}

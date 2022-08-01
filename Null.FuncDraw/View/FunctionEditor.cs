using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Null.FuncDraw.Model;
using Null.FuncDraw.Utils;

namespace Null.FuncDraw.View
{
    public partial class FunctionEditor : Form
    {
        public FunctionEditor(Form parent)
        {
            InitializeComponent();

            this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2, parent.Top + (parent.Height - this.Height) / 2);
            this.Shown += (sender, e) => this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2, parent.Top + (parent.Height - this.Height) / 2);
        }

        public ChainOptCalcFunction Function { get; set; }

        private void accept_Click(object sender, EventArgs e)
        {
            ChainOptCalcFunction result = new ChainOptCalcFunction(funcNameBox.Text);
            result.Operations.AddRange(operationList.Items.OfType<ISubOperation>());
            result.ForeCore = colorPanel.BackColor;

            Function = result;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int index = operationList.SelectedIndex;
            if (index >= 0)
                operationList.Items.RemoveAt(index);
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            int index = operationList.SelectedIndex;
            var items = operationList.Items;
            if (index >= 0 && index < items.Count - 1)
            {
                object temp = items[index];
                items[index] = items[index + 1];
                items[index + 1] = temp;
            }
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            int index = operationList.SelectedIndex;
            var items = operationList.Items;
            if (index > 0)
            {
                object temp = items[index];
                items[index] = items[index - 1];
                items[index - 1] = temp;
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            int index = operationList.SelectedIndex;
            if (index >= 0)
            {
                SubOperationEditor editor = new SubOperationEditor(this)
                {
                    SubOperation = operationList.SelectedItem as ISubOperation
                };

                if (editor.ShowDialog() == DialogResult.OK)
                    operationList.Items[index] = editor.SubOperation;
            }
        }

        private void append_Click(object sender, EventArgs e)
        {
            SubOperationEditor editor = new SubOperationEditor(this)
            {
                SubOperation = operationList.SelectedItem as ISubOperation
            };

            if (editor.ShowDialog() == DialogResult.OK)
                operationList.Items.Add(editor.SubOperation);
        }

        private void FunctionEditor_Load(object sender, EventArgs e)
        {
            if (Function != null)
            {
                operationList.Items.AddRange(Function.Operations.ToArray());
                colorPanel.BackColor = Function.ForeCore;

                this.funcNameBox.Text = Function.FunctionName;
            }
            else
            {
                colorPanel.BackColor = Color.FromArgb(NumUtil.RandomInt(0, 200), NumUtil.RandomInt(0, 200), NumUtil.RandomInt(0, 200));

                DateTime now = DateTime.Now;
                this.funcNameBox.Text = $"T-{now.Day}-{now.Hour}-{now.Minute}-{now.Second}";
            }
        }
        private void colorPanel_Click(object sender, EventArgs e)
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
                colorPanel.BackColor = dialog.Color;
        }
    }
}

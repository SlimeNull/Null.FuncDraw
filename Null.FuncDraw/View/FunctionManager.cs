using Null.FuncDraw.Model;
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

        public CalcFunction[] Functions { get => functionList.Items.OfType<CalcFunction>().ToArray(); }

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
                FunctionEditor editor = new FunctionEditor(this) { Function = items[index] as CalcFunction };

                if (editor.ShowDialog() == DialogResult.OK)
                {
                    items[index] = editor.Function;
                }
            }
        }

        private void append_Click(object sender, EventArgs e)
        {
            FunctionEditor editor = new FunctionEditor(this);

            if (editor.ShowDialog() == DialogResult.OK)
            {
                functionList.Items.Add(editor.Function);
            }
        }

        private void FunctionManager_Load(object sender, EventArgs e)
        {

        }
    }
}

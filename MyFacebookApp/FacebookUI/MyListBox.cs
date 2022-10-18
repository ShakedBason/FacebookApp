using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookUI
{
    public partial class MyListBox : ListBox
    {
        private static readonly string k_WhemEmptyText = "No data available.";

        public MyListBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xF)
            {
                if (this.Items.Count == 0)
                    using (var g = Graphics.FromHwnd(this.Handle))
                        TextRenderer.DrawText(g, k_WhemEmptyText, Font, ClientRectangle, ForeColor);
            }
        }
    }
}

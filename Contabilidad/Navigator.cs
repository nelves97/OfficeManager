using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class Navigator : Panel
    {
        public Navigator()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void NavigateTo(UserControl View)
        {
            Controls.Clear();
            Controls.Add(View);
        }

        public void ClearNavigator()
        {
            Controls.Clear();
        }
    }
}

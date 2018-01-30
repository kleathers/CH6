using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5
{
    public partial class TemperaturesForm : Form
    {
        public TemperaturesForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TextBox[] temps =
            {
                txtTemp1,
                txtTemp2,
                txtTemp3,
                txtTemp4,
                txtTemp5,
                txtTemp6,
                txtTemp7
            };
            Label[] deltas =
            {
                lblDelta1,
                lblDelta2,
                lblDelta3,
                lblDelta4,
                lblDelta5,
                lblDelta6,
                lblDelta7
            };

            // TODO: put code here...
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double total = 0.0d;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCaculate_Click(object sender, EventArgs e)
        {
            double totalPrices = Convert.ToInt32(textPrice.Text) * Convert.ToInt32(textNumber.Text);
            total += totalPrices;
            ltbList.Items.Add("单价：" + textPrice.Text + "  数量：" + textNumber.Text + "  合计：" + totalPrices);
            labTotalPrice.Text = total.ToString();
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            textNumber.Text = string.Empty;
            textPrice.Text = string.Empty;
            ltbList.Items.Clear();
            labTotalPrice.Text = string.Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShap_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            double HKI, HKII, DTB;
            HKI = Convert.ToDouble(txtHKI.Text);
            HKII = Convert.ToDouble(txtHKII.Text);
            DTB = (HKI + HKII) / 2;
            txtdtb.Text = Convert.ToString(DTB);
            if(DTB >= 5)
            {
                txtkq.Text = "Được lên lớp";
            }
            if(DTB < 5)
            {
                txtkq.Text = "Ở lại lớp";
            }
          
        }
    }
}

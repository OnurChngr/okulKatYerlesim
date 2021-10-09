using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okulKatYerleşim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            int k1, k2, k3;
            
            k1 = Convert.ToInt32(txtKat.Text);
            txtKat.Text = (k1.ToString());
            k2 = Convert.ToInt32(txtKat.Text);
            txtKat.Text = (k2.ToString());
            k3 = Convert.ToInt32(txtKat.Text);
            txtKat.Text = (k3.ToString());
            if (k1==1)
            {
                lstKat.Items.Add("9A-Sınıfı");
                lstKat.Items.Add("9B-Sınıfı");
                lstKat.Items.Add("9C-Sınıfı");
                lstKat.Items.Add("9D-Sınıfı");                
            }
            
            else if (k2==2)
            {
                lstKat.Items.Add("10A-Sınıfı");
                lstKat.Items.Add("10B-Sınıfı");
                lstKat.Items.Add("10C-Sınıfı");
                lstKat.Items.Add("10D-Sınıfı");                
            }
            else if(k3==3)
            {
                lstKat.Items.Add("11A-Sınıfı");
                lstKat.Items.Add("11B-Sınıfı");
                lstKat.Items.Add("11C-Sınıfı");
                lstKat.Items.Add("11D-Sınıfı");
            }
            
            
        }
    }
}

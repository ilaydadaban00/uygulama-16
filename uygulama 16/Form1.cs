using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkce_dogru, turkce_yanlıs, turkce_net, matematik_dogru, matematik__yanlıs, matematik_net;

            turkce_dogru = Convert.ToInt32(txtMatematikDogru.Text);
            turkce_yanlıs = Convert.ToInt32(txtTurkeceDogru.Text);
            turkce_net = turkce_dogru-(turkce_yanlıs / 4);
            MessageBox.Show("türkçe net"+ turkce_net.ToString()) ;

            matematik_dogru = Convert.ToInt32(txtMatematikDogru.Text);
            matematik__yanlıs = Convert.ToInt32(txtMatematikYanlıs.Text);
            matematik_net=matematik_dogru-(matematik__yanlıs/4);
            MessageBox.Show(matematik_net.ToString()+"matematik net");
        }
    }
}

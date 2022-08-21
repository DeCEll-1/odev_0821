using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0821odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label lbl_isim = new Label();
            this.Controls.Add(lbl_isim);
            lbl_isim.AutoSize = true;
            lbl_isim.Text = "İsim:";
            lbl_isim.Location = new Point(262, 40);

            Label lbl_soyisim = new Label();
            lbl_soyisim.Text = "soyisim:";
            lbl_soyisim.Location = new Point(262, 74);
            this.Controls.Add(lbl_soyisim);

            TextBox tb_isim = new TextBox();
            tb_isim.Location = new Point(300, 30);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

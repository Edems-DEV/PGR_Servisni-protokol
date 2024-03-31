using Servisni_protokol.Model;
using Servisni_protokol.Model.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servisni_protokol
{
    public partial class Form2_Preview : Form
    {
        public ServiceProtocol Sp { get; set; }
        public PreviewService s { get; set; }
        public Form2_Preview(ServiceProtocol sp)
        {
            InitializeComponent();
            Sp = sp;
            s = new PreviewService(Sp);

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            s.Draw(e.Graphics, pictureBox1.Width, pictureBox1.Height);
        }
    }
}

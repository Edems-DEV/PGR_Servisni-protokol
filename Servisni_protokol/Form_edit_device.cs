using Servisni_protokol.Model;
using Servisni_protokol.Services;
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
    public partial class Form_edit_device : Form
    {
        public Device D { get; set; }
        public Form_edit_device(Device d)
        {
            InitializeComponent();
            this.D = d;

            Prefill();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                D.Manufacturer = tb_Manufacturer.Text;
                D.Model = tb_Model.Text;
                D.SerialNumber = tb_SerialNumber.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Required(object sender, CancelEventArgs e)
        {
            MyValidation.Required(sender, e, errorProvider1);
        }

        private void Prefill()
        {
            if (!string.IsNullOrEmpty(D.Manufacturer))
                tb_Manufacturer.Text = D.Manufacturer;
            if (!string.IsNullOrEmpty(D.Model))
                tb_Model.Text = D.Model;
            if (!string.IsNullOrEmpty(D.SerialNumber))
                tb_SerialNumber.Text = D.SerialNumber;
        }

        #region Hide
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

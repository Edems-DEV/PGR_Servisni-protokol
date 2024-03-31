using Servisni_protokol.Model;
using Servisni_protokol.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servisni_protokol
{
    public partial class Form_edit_measurements : Form
    {
        public Measurement Mea { get; set; }
        public Form_edit_measurements(Measurement mea)
        {
            InitializeComponent();
            Mea = mea;

            Prefill();
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                Mea.Parametr = tb_parametr.Text;
                Mea.Value = Convert.ToDouble(tb_value.Text.Replace('.', ','));
                Mea.Unit = tb_unit.Text;
                Mea.IsValid = chb_IsValid.Checked;

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


        Regex re_VALUE = new Regex(@"^\d+(\.|,)?\d*$");
        private void Validate_Value(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_value.Text)) //first (cant use MyValidation)
            {
                errorProvider1.SetError(tb_value, "Required");
                e.Cancel = true;
            }
            else if (!re_VALUE.IsMatch(tb_value.Text))
            {
                errorProvider1.SetError(tb_value, "Pouze čísla");
                e.Cancel = true;
            }
            else { errorProvider1.SetError(tb_value, null); }
        }

        private void Prefill()
        {
            tb_parametr.Text = Mea.Parametr;
            tb_value.Text = Mea.Value.ToString();
            tb_unit.Text = Mea.Unit;
            chb_IsValid.Checked = Mea.IsValid;
        }

        #region Hide
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}

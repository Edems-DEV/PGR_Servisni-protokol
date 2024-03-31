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
    public partial class Form_edit_customer : Form
    {
        private Customer C { get; set; }
        public Form_edit_customer(Customer c)
        {
            InitializeComponent();
            C = c;

            Prefill();
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                C.Name = tb_Name.Text;
                C.Address = tb_Address.Text;
                C.Psc = tb_psc.Text;
                C.Ic = tb_ic.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Required(object sender, CancelEventArgs e)
        {
            MyValidation.Required(sender, e, errorProvider1);
        }

        Regex re_PSC = new Regex(@"^\d\d\d ?\d\d$");
        Regex re_IC = new Regex(@"^\d{6}$");
        private void Validate_Psc(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_psc.Text)) //first (cant use MyValidation)
            {
                errorProvider1.SetError(tb_psc, "Povíné");
                e.Cancel = true;
            }
            else if (!re_PSC.IsMatch(tb_psc.Text)) //&& errorProvider1.HasErrors
            {
                errorProvider1.SetError(tb_psc, "PSČ musí být ve tvaru 130 00");
                e.Cancel = true;
            }
            else { errorProvider1.SetError(tb_psc, null); }            
        }
        private void Validate_Ic(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ic.Text))
            {
                errorProvider1.SetError(tb_ic, "Povíné");
                e.Cancel = true;
            }
            else if (!re_IC.IsMatch(tb_ic.Text))
            {
                errorProvider1.SetError(tb_ic, "IČ musí obsahovat přesně 6 čísel");
                e.Cancel = true;
            }
            else { errorProvider1.SetError(tb_ic, null); }
        }

        private void Prefill()
        {
            if (!string.IsNullOrEmpty(C.Name))
                tb_Name.Text = C.Name;
            if (!string.IsNullOrEmpty(C.Address))
                tb_Address.Text = C.Address;
            if (!string.IsNullOrEmpty(C.Psc))
                tb_psc.Text = C.Psc;
            if (!string.IsNullOrEmpty(C.Ic))
                tb_ic.Text = C.Ic;
        }
    }
}

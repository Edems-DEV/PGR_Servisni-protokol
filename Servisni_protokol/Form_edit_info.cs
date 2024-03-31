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

namespace Servisni_protokol;

public partial class Form_edit_info : Form
{
    private ServiceProtocol Sp { get; set; }

    public Form_edit_info(ServiceProtocol sp)
    {
        InitializeComponent();
        Sp = sp;

        Prefill();
    }


    private void btn_ok_Click(object sender, EventArgs e)
    {
        if (ValidateChildren())
        {
            Sp.Number = tb_Id.Text;
            Sp.MeaDate = dtp_meaDate.Value;

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
        if (!string.IsNullOrEmpty(Sp.Number))
            tb_Id.Text = Sp.Number;
        if (Sp.MeaDate != DateTime.MinValue)
            dtp_meaDate.Value = Sp.MeaDate;
    }

    #region hide
    private void label1_Click(object sender, EventArgs e)
    {

    }

    //private void tb_Id_Validating(object sender, CancelEventArgs e)
    //{
    //    var s = sender as Control;

    //    if (string.IsNullOrWhiteSpace(s.Text))
    //    {
    //        errorProvider1.SetError(s, "Required");
    //        e.Cancel = true;
    //    }
    //}
    #endregion

}

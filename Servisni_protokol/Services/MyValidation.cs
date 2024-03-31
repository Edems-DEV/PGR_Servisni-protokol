using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servisni_protokol.Services;

public class MyValidation
{
    public static void Required(object sender, CancelEventArgs e, ErrorProvider ep)
    {
        var s = sender as Control;

        if (string.IsNullOrWhiteSpace(s.Text))
        {
            ep.SetError(s, "Required");
            e.Cancel = true;
        }
        else { ep.SetError(s, null); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servisni_protokol.Model.Interface;

public interface IHtmlSaveble
{
    public string ConvertToHtml();
    public string DefineCss();
}

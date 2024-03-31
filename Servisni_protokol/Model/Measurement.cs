using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Servisni_protokol.Model.Interface;

namespace Servisni_protokol.Model;

public class Measurement : IHtmlSaveble
{
    [DisplayName("Parametr")]
    public string Parametr { get; set; }

    [DisplayName("Nameřená Hodnota")]
    public double Value { get; set; }

    [DisplayName("Jednotka")]
    public string Unit { get; set; }

    [DisplayName("Vyhovuje")]
    public bool IsValid { get; set; }

    public string ConvertToHtml()
    {
        string a = (IsValid) ? "ANO" : "NE";
        string html = $"""
                <tr>
                    <td>{Parametr}</td>
                    <td>{Value}{Unit}</td>
                    <td>{a}</td>
                </tr>
            """;
        return html;
    }

    public string DefineCss()
    {
        string css = """
            div#mereni { clear:both; padding:1em; }
            div#mereni table { width:100%; }
            div#mereni table th { text-align:left; }
            """;
        return css;
    }
}

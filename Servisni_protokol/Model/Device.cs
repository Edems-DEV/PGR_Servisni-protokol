using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servisni_protokol.Model.Interface;

namespace Servisni_protokol.Model;

public class Device : IHtmlSaveble
{
    //private => public
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }

    public string ConvertToHtml()
    {
        string html = $"""
            <div id="zarizeni">
                <h2>Zařízení</h2>
                <div>Výrobce: {Manufacturer}</div>
                <div>Model: {Model}</div>
                <div>Sériové číslo: {SerialNumber}</div>
            </div>
            """;
        return html;
    }

    public string DefineCss()
    {
        string css = """
            div#zarizeni {
                border: 1px solid black;
                margin: 1em;
                padding: 1em;
                width: 40%;
                float: right;
            }
            """;
        return css;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servisni_protokol.Model.Interface;

namespace Servisni_protokol.Model;

public class Customer : IHtmlSaveble
{
    //Private => public
    public string Name { get; set; }
    public string Address { get; set; }
    public string Psc { get; set; }
    public string Ic { get; set; }

    public string ConvertToHtml()
    {
        string html = $"""
            <div id="zakaznik">
                <h2>Zákazník</h2>
                <div>Název: {Name}</div>
                <div>Adresa: {Address}</div>
                <div>PSČ: {Psc}</div>
                <div>IČ: {Ic}</div>
            </div>
            """;
        return html;
    }

    public string DefineCss()
    {
        string css = """
            div#zakaznik { 
                border:1px solid black; 
                margin:1em; padding:1em; 
                width:40%; 
                float:left; 
            }
            """;
        return css;
    }
}

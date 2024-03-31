using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Servisni_protokol.Model.Interface;

namespace Servisni_protokol.Model;

public class ServiceProtocol : IHtmlSaveble, IDraweble
{
    //private => public
    public string Number { get; set; }
    public DateTime MeaDate { get; set; }
    public Customer Customer { get; set; }
    public Device Device { get; set; }
    public BindingList<Measurement> Measurements { get; set; }

    public ServiceProtocol()
    {
        Measurements = new BindingList<Measurement>();
    }

    public bool IsValid()
    {
        bool isValid = true;
        foreach (Measurement mea in Measurements)
        {
            if (!mea.IsValid) { isValid = false; }
        }
        return isValid;
    }

    public void Draw(Graphics g)
    {
        throw new NotImplementedException();
    }

    public string ConvertToFullHtml()
    {
        string html = $"""
            <?xml version='1.0' encoding='UTF-8' ?><!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.1//EN' 'http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd'>
            <html xmlns='http://www.w3.org/1999/xhtml' xml:lang='cs'>
            <head>
            <meta http-equiv="content-type" content="text/html; charset=utf-8">
            <style type='text/css'>
                {DefineCss()}
            </style>
            </head>

            <body>
                {ConvertToHtml()}
            </body>
            </html>
            
            """;
        return html;
    }
    public string ConvertToHtml()
    {
        string status = IsValid() ? "je" : "není";
        string trs = "";
        foreach (Measurement mea in Measurements)
        {
            trs += mea.ConvertToHtml();
        }
        string html = $"""
            <div id="protokol">
                <h1>Potvrzení o provedení měření</h1>
                <div id='datum'>{MeaDate.ToString("d")}</div>
                <div id='cisloProtokolu'>Číslo protokolu: {Number}</div>

                {Device.ConvertToHtml()}

                {Customer.ConvertToHtml()}

                <div id='mereni'>
                    <h2>Měření</h2>
                    <table>
                    <tr> <th>Parametr</th> <th>Naměřená hodnota</th> <th>Vyhovuje</th> </tr>
                    {trs}
                    </table>
                </div>
                <div id='zaver'>Zařízení {status} schopné dalšího provozu</div>
            </div>
            """;
        return html;
    }

    public string DefineCss()
    {
        string css = """
            h1 { text-align:center; }
            div#protokol { margin:2em; border:1px solid black; }
            div#datum { float:left; margin:1em; width:40%;  }
            div#cisloProtokolu { text-align:right; float:right; margin:1em; width:40%; }
            div#zaver { text-align:center; font-weight:bold; font-size:1.2em; }
            """;
        css += Device.DefineCss();
        css += Customer.DefineCss();
        if (Measurements[0] != null)
            css += Measurements[0].DefineCss(); //ok?

        return css;
    }

    //-----------------------------

    public void Import(string fullpath)
    {
        string json = "";
        using (var sr = new StreamReader(fullpath))
        {
            json = sr.ReadToEnd();
        }

        var a = JsonSerializer.Deserialize<ServiceProtocol>(json);

        Number = a.Number;
        MeaDate = a.MeaDate;
        Customer = a.Customer;
        Device = a.Device;

        Measurements.Clear();
        foreach (var mea in a.Measurements)
        {
            Measurements.Add(mea);
        }
    }
    public void Export(string fullpath)
    {
        string json = JsonSerializer.Serialize(this);

        using (var sw = new StreamWriter(fullpath))
        {
            sw.WriteLine(json);
        }
    }

    public void SaveHtml(string fullpath)
    {
        using (var sw = new StreamWriter(fullpath))
        {
            sw.WriteLine(ConvertToFullHtml());
        }
    }
}

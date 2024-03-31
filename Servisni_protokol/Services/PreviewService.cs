using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

namespace Servisni_protokol.Model.My;

public class PreviewService
{
    public ServiceProtocol Sp { get; set; }
    private Graphics g { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public PreviewService(ServiceProtocol sp)
    {
        this.Sp = sp;
        //this.g = e;
        //this.Width = width;
        //this.Height = heigth;
    }
    public void Draw(Graphics e, int w, int h)
    {
        Width = w;
        Height = h;
        g = e;

        int x = 10; //padding
        int y = 10;

        g.DrawRectangle(Pens.Black, x, y, Width - x*2, Height - y * 2); //frame

        //Title
        y += DrawTextCenter(y, "Potvrzení o provedení měření", 16);
        
        //Info
        y += DrawEndStart(y, $"Datum měření: {Sp.MeaDate.ToString("d")}", 
                             $"Číslo protokolu: {Sp.Number}");
        //Boxes
        y += DrawBoxData(x,y, 
            "Zákazník", 
            $"Název: {Sp.Customer.Name}",
            $"Adresa: {Sp.Customer.Address}",
            $"PSČ: {Sp.Customer.Psc}",
            $"IČ: {Sp.Customer.Ic}"
        );
        DrawBoxData(Width/2, y,
            "Zařízení",
            $"Výrobce: {Sp.Device.Manufacturer}",
            $"Model: {Sp.Device.Model}",
            $"Sériové číslo: {Sp.Device.SerialNumber}"
        );

        //Mea
        y += DrawHeader(x, y, "Měření");
        y += DrawItem(x, y, "Parametr", "Naměřená hodnota", "Vyhovuje", true);
        foreach (var mea in Sp.Measurements)
        {
            y += DrawItem(x, y, mea.Parametr, mea.Value.ToString()+mea.Unit, (mea.IsValid) ? "ANO" : "NE");
            y += 5; //margin
        }

        //Result
        string valid = (Sp.IsValid()) ? "je" : "není";
        y += DrawTextCenter(y, $"Zařízení {valid} schopné dalšího provozu", 15);
    }

    private int DrawItem(int x, int y, string start, string mid, string end, bool bold = false)
    {
        Font f;
        if (bold) { f = new Font("Arial", 12, FontStyle.Bold);  }
        else      { f = new Font("Arial", 12); }
        var b = new SolidBrush(Color.Black);

        SizeF mid_mea = g.MeasureString(mid, f);
        SizeF end_mea = g.MeasureString(end, f);

        int xCenter = (Width / 2) + (int)mid_mea.Width / 2;
        int xEnd = (Width) + (int)end_mea.Width / 2;

        g.DrawString(start, f, b, x, y);
        g.DrawString(mid, f, b, xCenter, y);
        g.DrawString(end, f, b, xEnd, y);

        return (int)mid_mea.Height;
    }
    private int DrawTextCenter(int y, string text, int size = 16)
    {
        var f = new Font("Arial", size, FontStyle.Bold);
        var b = new SolidBrush(Color.Black);

        SizeF mea = g.MeasureString(text, f);

        g.DrawString(text, f, b, Width/2 + (int)mea.Width/2, y);

        return (int)mea.Height;
    }

    private int DrawEndStart(int y, string text1, string text2, int size = 12)
    {
        var f = new Font("Arial", size);
        var b = new SolidBrush(Color.Black);
        SizeF mea = g.MeasureString(text1, f);

        g.DrawString(text1, f, b, (int)mea.Width / 2, y);

        return (int)mea.Height;
    }

    private int DrawBoxData(int x, int y, string title, params string[] values)
    {
        int X = x;
        int Y = y;
        int margin = 5;

        X += margin;
        Y += margin;

        Y += DrawHeader(X,Y,title);
        foreach (var val in values)
            Y += DrawText(X, Y, val);

        Y += margin;

        g.DrawRectangle(Pens.Black, x, y, X, Y);
        return Y;
    }

    private int DrawHeader(int x, int y, string text)
    {
        int height = DrawText(x, y, text, 14, true);

        int bottom_margin = 5;

        return height + bottom_margin;
    }
    private int DrawText(int x, int y, string text, int size = 12, bool isBold = false)
    {
        Font f;
        if (isBold) { f = new Font("Arial", 12, FontStyle.Bold); }
        else { f = new Font("Arial", 12); }
        var b = new SolidBrush(Color.Black);
        SizeF mea = g.MeasureString(text, f);

        g.DrawString(text, f, b, x, y);

        return (int)mea.Height;
    }
}

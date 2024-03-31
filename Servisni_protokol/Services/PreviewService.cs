using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
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

        int x = 20; //padding
        int y = 20;

        g.DrawRectangle(Pens.Black, x/2, y/2, Width - x, Height - y); //frame

        //Title
        y += DrawH1(x, y, "Potvrzení o provedení měření", 16);
        y += 10;
        
        //Info
        y += DrawEndStart(x, y, $"Datum měření: {Sp.MeaDate.ToString("d")}", 
                                $"Číslo protokolu: {Sp.Number}");
        y += 5;

        //Boxes
        int aa = 0;
        aa = DrawBoxData(x,y, 
            "Zákazník", 
            $"Název: {Sp.Customer.Name}",
            $"Adresa: {Sp.Customer.Address}",
            $"PSČ: {Sp.Customer.Psc}",
            $"IČ: {Sp.Customer.Ic}"
        );
        DrawBoxData(Width/2 - x+2, y,
            "Zařízení",
            $"Výrobce: {Sp.Device.Manufacturer}",
            $"Model: {Sp.Device.Model}",
            $"Sériové číslo: {Sp.Device.SerialNumber}"
        );
        y += aa + 10;

        //Mea
        y += DrawH2(x, y, "Měření");
        y += DrawItem(x, y, "Parametr", "Naměřená hodnota", "Vyhovuje", true);
        foreach (var mea in Sp.Measurements)
        {
            y += DrawItem(x, y, mea.Parametr, mea.Value.ToString()+mea.Unit, (mea.IsValid) ? "ANO" : "NE");
            y += 5; //margin
        }
        y += 20;

        //Result
        string valid = (Sp.IsValid()) ? "je" : "není";
        y += DrawH1(x, y, $"Zařízení {valid} schopné dalšího provozu", 15);
    }

    private int DrawBoxData(int x, int y, string title, params string[] values)
    {
        int X = x;
        int Y = y;
        int margin = 5;

        X += margin;
        Y += margin;

        Y += DrawH2(X,Y,title);
        foreach (var val in values)
            Y += DrawText(X, Y, val);

        Y += margin;

        g.DrawRectangle(Pens.Black, x, y, X, Y);
        return Y;
    }

    private int DrawItem(int x, int y, string start, string mid, string end, bool bold = false, int size = 12)
    {
        int a = DrawText(x, y, start, size, bold, 0f);
        DrawText(Width / 2 - x, y, mid, size, bold, 0.5f);
        DrawText(Width -x , y, end, size, bold, 1f);
        return a;
    }


    private int DrawEndStart(int x, int y, string text1, string text2, int size = 12)
    {
        int a = DrawText(x, y, text1, size, false);
        int b = DrawText(Width -x, y, text2, size, false, 1f);

        return (a > b) ? a : b;
    }

    private int DrawH1(int x, int y, string text, int size = 16)
    {
        return DrawText(Width / 2-x, y, text, size, true, 0.5f);
    }

    private int DrawH2(int x, int y, string text, int size = 14, int bottom_margin = 5)
    {
        int height = DrawText(x, y, text, size, true);

        return height + bottom_margin;
    }
    private int DrawText(int x, int y, string text, int size = 12, bool isBold = false, float wscale = 0)
    {
        float X = x;
        var f = new Font("Arial", size, isBold ? FontStyle.Bold : FontStyle.Regular);
        var b = new SolidBrush(Color.Black);
        SizeF mea = g.MeasureString(text, f);

        X -= mea.Width * wscale; // 0.5 = /2 | 1 = full | 0 = none

        g.DrawString(text, f, b, X, y);

        return (int)mea.Height;
    }
}

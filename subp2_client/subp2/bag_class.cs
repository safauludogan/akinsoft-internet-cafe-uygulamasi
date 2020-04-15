using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace subp2
{
    class bag_class
    {
        string bag;
        int sayac;
        string[] dizi = new string[16];
        public string baglan()
        {
            try
            {
                StreamReader oku = new StreamReader("sunucuBaglantisi\\subp2.txt");
                string satir = oku.ReadLine();
                while (satir != null)
                {
                    dizi[sayac] = satir;
                    sayac++;
                    satir = oku.ReadLine();
                }
                bag = "Server=" + dizi[0] + ";Port=" + dizi[1] + ";Database=" + dizi[2] + ";Uid=" + dizi[3] + ";Pwd=" + dizi[4] + ";Encrypt=false;AllowUserVariables=True;UseCompression=True;";
              
            }
            catch
            { }
            return bag;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        class Versenytav
        {
            private string Rajtszam;
            public string Tav
            {
                get
                {
                    switch (Rajtszam[0])
                    {
                        case 'M': return "Mini";
                        case 'R': return "Rövid";
                        case 'K': return "Közép";
                        case 'H': return "Hosszú";
                        case 'E': return "Pedelec";
                    }
                    return "Hibás rajtszám";
                }
            }
            public Versenytav(string rajtszam)
            {
                Rajtszam = rajtszam;
            }
        }
    }
}

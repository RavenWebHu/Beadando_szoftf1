using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando_szoftf
{
    public partial class Elsomatrix : Form
    {
        public Elsomatrix()
        {
            InitializeComponent();
        }

        public void EMAK()
        {

            int i, j;
            string bevitel;

            for (i=0; i< Form1.n; i++)
            {
                for (j=0; j<Form1.n; j++)
                {
                    bevitel = Convert.ToString(Form1.elsomatrix[i, j]);
                    elsobox.AppendText(bevitel + ", ");
                }
                elsobox.AppendText(Environment.NewLine);
            }  
        }

    }
}

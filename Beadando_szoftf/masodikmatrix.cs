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
    public partial class Masodikmatrix : Form
    {
        public Masodikmatrix()
        {
            InitializeComponent();
        }

        public void MMAK()
        {

            int i, j;
            string bevitel;

            for (i = 0; i < Form1.n; i++)
            {
                for (j = 0; j < Form1.n; j++)
                {
                    bevitel = Convert.ToString(Form1.masodikmatrix[i, j]);
                    masodikbox.AppendText(bevitel + ", ");
                }
                masodikbox.AppendText(Environment.NewLine);
            }
        }
    }
}

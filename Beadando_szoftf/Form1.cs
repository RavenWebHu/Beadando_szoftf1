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




    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int n;
        public static int[,] elsomatrix;
        public static int[,] masodikmatrix;

        Elsomatrix elsoablak = new Elsomatrix();
        Masodikmatrix masodikablak = new Masodikmatrix();

//Futattás gomb -----------------------------------------------------------------------------

        private void Bevitel_Click(object sender, EventArgs e)
        {
            if (Szamellenorzes())
            {
                Matrixgenerelas();

                //Matrixok beírása 
                elsoablak.EMAK();
                masodikablak.MMAK();
                
                //Matematikai műveletek végrehalytása
                atlofossz();
                atlooszk();
                skalar();

                //Felugró ablakok megnyitása
                elsoablak.Show();
                masodikablak.Show();
            }


        }

// Bevitt szám ellenörzése -----------------------------------------------------------------------------

        public bool Szamellenorzes()
        {


            try
            {
                n = Convert.ToInt32(szambevitel.Text);

                if (n > 15)
                {
                    MessageBox.Show("Túl nagy számot adtál meg",
                    "Hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return false;
                }
                else if (n < 5)
                {
                    MessageBox.Show("Túl kicsi számot adtál meg",
                    "Hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return false;
                }
                else return true;
            }

            catch
            {
                MessageBox.Show("Nem számot adtál meg",
                "Hiba",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;
            }

        }

//Mátrixok legenerálása ---------------------------------------------------------------------

        public void Matrixgenerelas()
        {

            var rsz = new Random();
            int i, j;

            elsomatrix = new int[n, n];
            masodikmatrix = new int[n, n];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    elsomatrix[i, j] = rsz.Next(-11, 10);
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    masodikmatrix[i, j] = rsz.Next(-11, 10);
                }
            }
        }

        //Skaláris szotzás----------------------------------------------------------------------

        private void skalar()
        {
            int i, j, osszeg = 0;


            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    osszeg += elsomatrix[i, j] * masodikmatrix[i,j];
                }
            }

            if (osszeg > 0)
            {
                skalarbox.ForeColor = Color.Blue;
            }
            else skalarbox.ForeColor = Color.Red;

            skalarbox.Text = Convert.ToString(osszeg);

        }

//Átlók összege -------------------------------------------------------------------------

            private void atlooszk()
        {
            int i, j, aoosszeg = 0;


            for (i = 0; i < n ; i++)
            {
                for (j = i ; j <= i; j++)
                {
                    aoosszeg += elsomatrix[i, j];
                }
            }

            for (i = 0; i < n ; i++)
            {
                for (j = i ; j <= i; j++)
                {
                    aoosszeg -= masodikmatrix[i, j];
                }
            }

            for (i = 0; i< n; i++)
            {
                for (j = n - i; j < n - i; j++)
                {
                    aoosszeg += elsomatrix[i, j];
                }
            }

            for (i = 0; i < n ; i++)
            {
                for (j = n - i; j < n - i; j++)
                {
                    aoosszeg -= masodikmatrix[i, j];
                }
            }

            if (aoosszeg > 0)
            {
                atlook.ForeColor = Color.Blue;
            }
            else atlook.ForeColor = Color.Red;

            atlook.Text = Convert.ToString(aoosszeg);
        }


    


    //Átlók feletti összeg-------------------------------------------------------------------

    private void atlofossz()
        {
            int i, j, aosszeg=0;
            

            for (i = 0; i-1 < n/2 ; i++)
            {
                for (j = i+1; j < n-1-i; j++)
                {
                    aosszeg+=elsomatrix[i, j];
                }
            }

            if (aosszeg > 0)
            {
                kao.ForeColor = Color.Blue;
            }
            else kao.ForeColor = Color.Red;


            kao.Text = Convert.ToString(aosszeg);
        }


    }
}

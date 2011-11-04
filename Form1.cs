using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testowaZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int Funkcja()
        {
            return 1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Dzwiek plikDzwiekowy = new Dzwiek();
            Dzwiek plikDzwiekowy2 = new Dzwiek();
            Obraz plikBitmapa = new Obraz();
            //dodanie funkcjonalnosci

            OtworzPlik(plikDzwiekowy2);
            OtworzPlik(plikBitmapa);
            OtworzPlik(plikDzwiekowy);
            OtworzPlik(plikDzwiekowy);
            
        }
        void OtworzPlik(Plik jakisPlik)
        {
            this.Text += "  " + jakisPlik.Otworz();
            

        }
    }
}

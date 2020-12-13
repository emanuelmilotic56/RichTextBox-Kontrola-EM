﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox_Kontrola_EM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSpremi_Click_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:Tempproba.rtf");

            MessageBox.Show("Tekst spremljen");
        }

        private void buttonCitaj_Click_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:Tempproba.rtf");
        }

        private void buttonBrisi_Click_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}

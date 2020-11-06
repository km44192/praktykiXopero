﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planowanie_przyjęcia
{
    public partial class Form1 : Form
    {
        DinnerParty Impreza=new DinnerParty();
        BirthdayParty Uro;
        public Form1()
        {
            InitializeComponent();

            BirthdayParty Urodziny = new BirthdayParty((int)NumOfPeople.Value, deco1.Checked, NapisTort.Text);
            wynik2.Text = Urodziny.KosztimprezyUrodzinowe().ToString("c");
            Uro = Urodziny;
        }
        
        
        private void fit_CheckedChanged(object sender, EventArgs e)
        {

            Impreza.fit = fit.Checked;
            kwota.Text = Impreza.KosztImprezy(fit.Checked).ToString("c");
        }

        private void deco_CheckedChanged(object sender, EventArgs e)
        {
            Impreza.deco = deco.Checked;
            kwota.Text = Impreza.KosztImprezy(fit.Checked).ToString("c");

        }

        private void kwota_Click(object sender, EventArgs e)
        {
            Impreza.Partyamm((int)IleGosci.Value);
         
            kwota.Text = Impreza.KosztImprezy(fit.Checked).ToString("c");
        }

        private void NumOfPeople_ValueChanged(object sender, EventArgs e)
        {
            alert.Text=Uro.WriteAlert();
            Uro.Partyamm((int)NumOfPeople.Value);
            Uro.IloscGosci = (int)NumOfPeople.Value;
            wynik2.Text = Uro.KosztimprezyUrodzinowe().ToString("C");
        }

        private void deco1_CheckedChanged(object sender, EventArgs e)
        {
           alert.Text= Uro.WriteAlert();
            Uro.deco = deco1.Checked;
          

            wynik2.Text = Uro.KosztimprezyUrodzinowe().ToString("C");
        }

        private void NapisTort_TextChanged(object sender, EventArgs e)
        {
            Uro.WriteAlert();
           
            Uro.CakeWriting = NapisTort.Text;
            wynik2.Text = Uro.KosztimprezyUrodzinowe().ToString("C");
        }
    }
}

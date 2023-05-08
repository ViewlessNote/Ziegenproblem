using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stochastik
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
       
        int ferari;
        int zufall2;
        int counter;
        int Winratestay;
        int winrateswitch;
        int auswahl;
        int Lost;
        int WinsTotal;
        int LostCousStay;
        int LostCousSwitch;

        public Form1()
        {
            InitializeComponent();
            ferari = rnd.Next(1, 4);
            tür1.BackColor = Color.Gray;
            tür2.BackColor = Color.Gray;
            tür3.BackColor = Color.Gray;
        }

        



        private void tür1_Click_1(object sender, EventArgs e)
        {
            try
            {
                

                if (counter == 0)
                {
                    tür1.BackColor = Color.Red;
                    label1.Text = "Möchtern sie die Tür wechseln ?";
                    auswahl = 1;
                    if (ferari != 2 && ferari != 3)
                    {
                       int tempSwitch = rnd.Next(1, 3);
                        switch (tempSwitch)
                        {
                            case 1:
                                Tür2Ziege.Show();
                                Tür2Ziege.BringToFront();
                                break;
                            case 2:
                                Tür3Ziege.Show();
                                Tür3Ziege.BringToFront();
                                break;
                        }
                    }
                    else
                    {
                        if (ferari != 2)
                        {
                            Tür2Ziege.Show();
                            Tür2Ziege.BringToFront();
                        }
                        if (ferari != 3)
                        {
                            Tür3Ziege.Show();
                            Tür3Ziege.BringToFront();
                        }
                    }
                }

                if (counter == 1)
                {
                    switch (ferari)
                    {
                        case 1:
                            Tür1AutoBild.Show();
                            Tür1AutoBild.BringToFront();
                            label1.Text = "You Won";
                            Tür2Ziege.Show();
                            Tür2Ziege.BringToFront();
                            Tür3Ziege.Show();
                            Tür3Ziege.BringToFront();
                            if (auswahl == 1)
                            {
                                Winratestay++;
                            }
                            else
                            {
                                winrateswitch++;
                            }

                            break;
                        case 2:
                            Tür2Auto.Show();
                            Tür2Auto.BringToFront();
                            label1.Text = "You Lost";
                            Tür1Ziege.Show();
                            Tür1Ziege.BringToFront();
                            Tür3Ziege.Show();
                            Tür3Ziege.BringToFront();
                            Lost++;

                            if (auswahl == 1)
                            {
                                LostCousStay++;
                            }
                            if (auswahl == 2)
                            {
                                LostCousSwitch++;
                            }

                            break;
                        case 3:
                            Tür3Auto.Show();
                            Tür3Auto.BringToFront();
                            label1.Text = "You Lost";
                            Tür2Ziege.Show();
                            Tür2Ziege.BringToFront();
                            Tür1Ziege.Show();
                            Tür1Ziege.BringToFront();
                            Lost++;

                            if (auswahl == 1)
                            {
                                LostCousStay++;
                            }
                            if (auswahl == 3)
                            {
                                LostCousSwitch++;
                            }

                            break;

                    }

                }
                counter++;

            }
            catch (Exception)
            {
                MessageBox.Show("Lappen");

            }
        }

        private void tür2_Click(object sender, EventArgs e)
        {
            try
            {

                if (counter == 0)
                {
                    tür2.BackColor = Color.Red;
                    label1.Text = "Möchtern sie die Tür wechseln ?";
                    auswahl = 2;
                    if (ferari != 1 && ferari != 3)
                    {
                        int tempSwitch = rnd.Next(1, 3);
                        switch (tempSwitch)
                        {
                            case 1:
                                Tür1Ziege.Show();
                                Tür1Ziege.BringToFront();
                                break;
                            case 2:
                                Tür3Ziege.Show();
                                Tür3Ziege.BringToFront();
                                break;
                        }
                    }
                    else
                    {
                        if (ferari != 1)
                        {
                            Tür1Ziege.Show();
                            Tür1Ziege.BringToFront();
                        }
                        if (ferari != 3)
                        {
                            Tür3Ziege.Show();
                            Tür3Ziege.BringToFront();
                        }
                    }
                }
                    if (counter == 1)
                    {
                        switch (ferari)
                        {
                            case 1:
                                Tür1AutoBild.Show();
                                Tür1AutoBild.BringToFront();
                                label1.Text = "You Lost";
                                Tür2Ziege.Show();
                                Tür2Ziege.BringToFront();
                                Tür3Ziege.Show();
                                Tür3Ziege.BringToFront();
                                Lost++;

                            if (auswahl == 2)
                            {
                                LostCousStay++;
                            }
                            if (auswahl == 1)
                            {
                                LostCousSwitch++;
                            }

                            break;
                            case 2:
                                Tür2Auto.Show();
                                Tür2Auto.BringToFront();
                                label1.Text = "You Won";
                                Tür1Ziege.Show();
                                Tür1Ziege.BringToFront();
                                Tür3Ziege.Show();
                                Tür3Ziege.BringToFront();
                                if (auswahl == 2)
                                {
                                    Winratestay++;
                                }
                                else
                                {
                                    winrateswitch++;
                                }

                                break;
                            case 3:
                                Tür3Auto.Show();
                                Tür3Auto.BringToFront();
                                label1.Text = "You Lost";
                                Tür2Ziege.Show();
                                Tür2Ziege.BringToFront();
                                Tür1Ziege.Show();
                                Tür1Ziege.BringToFront();
                                Lost++;

                            if (auswahl == 2)
                            {
                                LostCousStay++;
                            }
                            if (auswahl == 3)
                            {
                                LostCousSwitch++;
                            }

                            break;

                        }
                    }
                    counter++;

                
            }
            catch (Exception)
            {
                MessageBox.Show("Lappen");


            }
        }
            private void tür3_Click(object sender, EventArgs e)
        {
            try
            {

                if (counter == 0)
                {
                    tür3.BackColor = Color.Red;
                    label1.Text = "Möchtern sie die Tür wechseln ?";
                    auswahl = 3;
                    if (ferari != 2 && ferari != 3)
                    {
                        int tempSwitch = rnd.Next(1, 3);
                        switch (tempSwitch)
                        {
                            case 1:
                                Tür2Ziege.Show();
                                Tür2Ziege.BringToFront();
                                break;
                            case 2:
                                Tür1Ziege.Show();
                                Tür1Ziege.BringToFront();
                                break;
                        }
                    }
                    else
                    {
                        if (ferari != 2)
                        {
                            Tür2Ziege.Show();
                            Tür2Ziege.BringToFront();
                        }
                        if (ferari != 3)
                        {
                            Tür1Ziege.Show();
                            Tür1Ziege.BringToFront();
                        }
                    }
                }
                    if (counter == 1)
                    {
                        switch (ferari)
                        {
                            case 1:
                                Tür1AutoBild.Show();
                                Tür1AutoBild.BringToFront();
                                label1.Text = "You Lost";
                                Tür2Ziege.Show();
                                Tür2Ziege.BringToFront();
                                Tür3Ziege.Show();
                                Tür3Ziege.BringToFront();
                                Lost++;

                            if (auswahl == 3)
                            {
                                LostCousStay++;
                            }
                            if (auswahl == 1)
                            {
                                LostCousSwitch++;
                            }

                            break;
                            case 2:
                                Tür2Auto.Show();
                                Tür2Auto.BringToFront();
                                label1.Text = "You Lost";
                                Tür1Ziege.Show();
                                Tür1Ziege.BringToFront();
                                Tür3Ziege.Show();
                                Tür3Ziege.BringToFront();
                                Lost++;

                            if (auswahl == 3)
                            {
                                LostCousStay++;
                            }
                            if (auswahl == 2)
                            {
                                LostCousSwitch++;
                            }

                            break;
                            case 3:
                                Tür3Auto.Show();
                                Tür3Auto.BringToFront();
                                label1.Text = "You Won";
                                Tür2Ziege.Show();
                                Tür2Ziege.BringToFront();
                                Tür1Ziege.Show();
                                Tür1Ziege.BringToFront();
                                if (auswahl == 3)
                                {
                                    Winratestay++;
                                }
                                else
                                {
                                    winrateswitch++;
                                }

                                break;

                        }
                    }
                    counter++;

                
            }
            catch (Exception)
            {
                MessageBox.Show("Lappen");


            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            WinsTotal = winrateswitch + Winratestay;
            counter = 0;
            tür1.Show();
            tür2.Show();
            tür3.Show();
            tür1.BringToFront();
            tür2.BringToFront();
            tür3.BringToFront();
            tür1.BackColor = Color.Gray;
            tür2.BackColor = Color.Gray;
            tür3.BackColor = Color.Gray;
            label1.Text = "Klicken sie auf eine Tür";
            ferari = rnd.Next(1, 4);
            LostLabel.Text = "You Lost " + Lost + " Times";
            LabelLostCousSwitch.Text = "Lost cous Change: "+LostCousSwitch;
            labelLostCousStay.Text = "Lost Cous Stay: "+LostCousStay;
            WinChange.Text = "Win Cous Change: " + winrateswitch;
            WinStay.Text = "Win Cous Stay: " + Winratestay;
            labelwinsTotal.Text = "Gesamte Wins: "+WinsTotal ;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void WinChange_Click(object sender, EventArgs e)
        {

        }

        private void WinStay_Click(object sender, EventArgs e)
        {

        }

        private void LostLabel_Click(object sender, EventArgs e)
        { 
            
        }

        private void LabelLostCousSwitch_Click(object sender, EventArgs e)
        {

        }

        private void labelwinsTotal_Click(object sender, EventArgs e)
        {

        }
    }
}

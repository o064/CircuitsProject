using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace CircuitsProject
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }


        public Data Sim(double R, double L, double C, double Io, double Vo, string type, string connection, double value = 0)
        {
            string Csol = (connection == "Series") ? ((type == "Natural") ? "I" : "Vc") : ((type == "Natural") ? "V" : "IL");
            double alpha, owmega;
            int state; 
            if (connection == "Parallel")
                alpha = 1 / (2 * R * C);
            else
                alpha = R / (2 * L);
            owmega = 1 / Math.Sqrt((L * C));
            owmega = Math.Round(owmega, 3);
            alpha = Math.Round(alpha, 3);


            double final = value;
            double C1, C2;
            if (alpha > owmega)
            {
                double s1 = -alpha + Math.Sqrt(Math.Pow(alpha, 2) - Math.Pow(owmega, 2));
                double s2 = -alpha - Math.Sqrt(Math.Pow(alpha, 2) - Math.Pow(owmega, 2));
                state = 0;

                if (connection == "Parallel")
                {
                    if (type == "Natural")
                    {
                        double der0 = (-Vo / R - Io) / C;

                        C1 = (der0 - s2 * Vo) / (s1 - s2);
                        C2 = Vo - C1;

                    }
                    else
                    {
                        double der0 = Vo / L;

                        C1 = (der0 - s2 * (Io - final)) / (s1 - s2);
                        C2 = Io - final - C1;


                    }
                }
                else
                {

                    if (type == "Natural")
                    {
                        double der0 = (Vo - Io * R) / L;
                        C1 = (der0 - s2 * Io) / (s1 - s2);
                        C2 = Io - C1;

                    }
                    else
                    {
                        double der0 = (Io) / C;
                        C1 = (der0 - s2 * (Vo - final)) / (s1 - s2);
                        C2 = Vo - final - C1;
                    }
                }
                C1 = Math.Round(C1, 3);
                C2 = Math.Round(C2, 3);
                return new Data(C1, C2, Math.Round(s1, 3), Math.Round(s2, 3), state, Csol,final);
            }
            else if(alpha == owmega)
            {
                state = 1;

                if (connection == "Parallel")
                {
                    if (type == "Natural")
                    {
                        double der0 = (-Vo / R - Io) / C;
                        C1 = Vo;
                        C2 = der0 + alpha * C1;

                    }
                    else
                    {
                        double der0 = Vo / L;
                        C1 = Io - final;
                        C2 = der0 + alpha * C1;

                    }
                }
                else
                {
                    if (type == "Natural")
                    {
                        double der0 = (Vo - Io * R) / L;
                        C1 = Io;
                        C2 = der0 + alpha * C1;

                    }
                    else
                    {
                        double der0 = (Io) / C;
                        C1 = Vo - final;
                        C2 = der0 + alpha * C1;

                    }
                }
                C1 = Math.Round(C1, 3);
                C2 = Math.Round(C2, 3);
                return new Data(C1, C2, Math.Round(-alpha,3), Math.Round(-alpha, 3), state, Csol,final);
            }
            else
            {
                double wd = Math.Sqrt(Math.Pow(owmega, 2) - Math.Pow(alpha, 2));
                wd = Math.Round(wd, 3);
                state = 2;
                if (connection == "Parallel")
                {

                    if (type == "Natural")
                    {
                        double der0 = (-Vo / R - Io) / C;
                        C1 = Vo;
                        C2 = (der0 + alpha * C1) / wd;

                    }
                    else
                    {
                        double der0 = Vo / L;
                        C1 = Io - final;
                        C2 = (der0 + alpha * C1) / wd;

                    }
                }else
                {

                    if (type == "Natural")
                    {
                        double der0 = (Vo - Io * R) / L;
                        C1 = Io;
                        C2 = (der0 + alpha * C1) / wd;
                    }
                    else
                    {
                        double der0 = (Io) / C;
                        C1 = Vo - final;
                        C2 = (der0 + alpha * C1) / wd;

                    }
                }
                C1 = Math.Round(C1, 3);
                C2 = Math.Round(C2, 3);
                return new Data(C1, C2, Math.Round(-alpha, 3), Math.Round(wd, 3), state,Csol,final);

            }

        }
        private void Simulate_Click(object sender, EventArgs e)
        {
            PlotForm plot = new PlotForm();
            int index = 0;
            foreach (Control control in pnlMain.Controls)
            {
                if (control is uclInfo ucl)
                {
                    if (!double.TryParse(ucl.txbR.Text, out double R))
                    {
                        MessageBox.Show("Please enter a valid positive value for R in the control at index " + index + ".");
                        return; // Skip to the next control
                    }

                    // Parsing L
                    if (!double.TryParse(ucl.txbL.Text, out double L) )
                    {
                        MessageBox.Show("Please enter a valid positive value for L in the control at index " + index + ".");
                        return; // Skip to the next control
                    }

                    // Parsing C
                    if (!double.TryParse(ucl.txbC.Text, out double C) )
                    {
                        MessageBox.Show("Please enter a valid positive value for C in the control at index " + index + ".");
                        return; // Skip to the next control
                    }

                    // Parsing Io
                    if (!double.TryParse(ucl.txbIO.Text, out double Io))
                    {
                        MessageBox.Show("Please enter a valid value for Io in the control at index " + index + ".");
                        return; // Skip to the next control
                    }

                    // Parsing Vo
                    if (!double.TryParse(ucl.txbVO.Text, out double Vo))
                    {
                        MessageBox.Show("Please enter a valid value for Vo in the control at index " + index + ".");
                        return; // Skip to the next control
                    }

                    // Checking if response type is selected
                    if (ucl.cbResponse.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a response type in the control at index " + index + ".");
                        return; // Skip to the next control
                    }
                    string type = ucl.cbResponse.SelectedItem.ToString();

                    // Checking if connection type is selected
                    if (ucl.cbConnection.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a connection type in the control at index " + index + ".");
                        return; // Skip to the next control
                    }
                    string connection = ucl.cbConnection.SelectedItem.ToString();

                    // Parsing value
                    if (!double.TryParse(ucl.txbSourceValue.Text, out double value))
                    {
                        MessageBox.Show("Please enter a valid value for the source in the control at index " + index + ".");
                        return; // Skip to the next control
                    }

                    if (R <= 0 || L <= 0 || C <= 0)
                    {
                        continue;
                    }
                    // Perform calculations
                    Data data = Sim(R, L, C, Io, Vo, type, connection,value);
                    plot.PlotData(data, index);
                    index++;
                }
            }
            plot.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
            //Note
        }



        private void uclIInfo1_Load(object sender, EventArgs e)
        {
            
        }

        private void uclIInfo2_Load(object sender, EventArgs e)
        {

        }

        private void uclIInfo3_Load(object sender, EventArgs e)
        {

        }



        private void btnMinmized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

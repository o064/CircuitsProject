using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace CircuitsProject
{
    public partial class Form1 : Form
    {
        List<double> xValues = new List<double>();
        List<double> yValues = new List<double>();


        public Form1()
        {
            InitializeComponent();
            Sim(80 , 5e-3, 2e-6,0,50,"Step", "Series",100);

        }

        
        public void Sim(double R, double L, double C, double Io, double Vo, string type, string connection, double value = 0)
        {
            string Csol;
            if (connection == "Series")

                Csol = (type == "Natural") ? "I" : "Vc";

            else

                Csol = (type == "Natural") ? "V" : "IL";


            double alpha, owmega;
            if (connection == "Parallel")
                alpha = 1 / (2 * R * C);
            else
                alpha = R / (2 * L);
            owmega = 1 / Math.Sqrt((L * C));
            alpha = Math.Round(alpha, 3);
            owmega = Math.Round(owmega, 3);
            double final = value;
            double C1, C2;
            if (connection == "Parallel")
            {
                if (alpha > owmega)
                {

                    double s1 = -alpha + Math.Sqrt(Math.Pow(alpha, 2) - Math.Pow(owmega, 2));
                    double s2 = -alpha - Math.Sqrt(Math.Pow(alpha, 2) - Math.Pow(owmega, 2));
                    if (type == "Natural")
                    {
                        double der0 = ( -Vo / R - Io ) / C;

                        C1 = (der0 - s2 * Vo) / (s1 - s2);
                        C2 = Vo - C1;

                    }
                    else
                    {
                        double der0 = Vo / L;

                        C1 = (der0 - s2 * (Io - final)) / (s1 - s2);
                        C2 = Io - final - C1;


                    }
                    C1 = Math.Round(C1, 3);
                    C2 = Math.Round(C2, 3);
                    result.Text = displayOverDamped(Csol, s1, s2, C1, C2, final);


                }
                if(alpha == owmega)
                {
                    if (type == "Natural")
                    {
                        double der0 = (-Vo / R - Io) / C;
                        C1 = Vo ;
                        C2 = der0 + alpha * C1;

                    }
                    else
                    {
                        double der0 = Vo / L;
                        C1 = Io - final;
                        C2 = der0 + alpha * C1;

                    }
                    C1 = Math.Round(C1, 3);
                    C2 = Math.Round(C2, 3);
                    result.Text = displayCriticallyDamped(Csol, -alpha, C1, C2, final);
                }
                if(alpha < owmega)
                {
                    double wd =  Math.Sqrt(Math.Pow(owmega, 2) - Math.Pow(alpha, 2));
                    wd = Math.Round(wd, 3);

                    if (type == "Natural")
                    {
                        double der0 = (-Vo / R - Io) / C;
                        C1 = Vo ;
                        C2 =( der0 + alpha * C1)/wd;

                    }
                    else
                    {
                        double der0 = Vo / L;
                        C1 = Io - final;
                        C2 = (der0 + alpha * C1) / wd;

                    }
                    C1 = Math.Round(C1, 3);
                    C2 = Math.Round(C2, 3);
                    result.Text = displayUnderDamped(Csol, -alpha, wd, C1, C2, final);

                }
            }
            else
            {

                if (alpha > owmega)
                {
                    double s1 = -alpha + Math.Sqrt(Math.Pow(alpha, 2) - Math.Pow(owmega, 2));
                    double s2 = -alpha - Math.Sqrt(Math.Pow(alpha, 2) - Math.Pow(owmega, 2));
                    if (type == "Natural")
                    {
                        double der0 = (Vo - Io * R) /L ;
                        C1 = (der0 - s2 * Io) / (s1 - s2);
                        C2 = Io - C1;

                    }
                    else
                    {
                        double der0 = (Io) / C;
                        C1 = (der0 - s2 * (Vo - final)) / (s1 - s2);
                        C2 = Vo - final - C1;
                    }
                    C1 =Math.Round(C1, 3);
                    C2 = Math.Round(C2, 3);
                    result.Text = displayOverDamped(Csol, s1, s2, C1, C2, final);
                }
                if (alpha == owmega)
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
                    C1 = Math.Round(C1, 3);
                    C2 = Math.Round(C2, 3);
                    result.Text = displayCriticallyDamped(Csol, -alpha, C1, C2, final);

                }
                if (alpha < owmega)
                {
                    double wd =  Math.Sqrt(Math.Pow(owmega, 2) - Math.Pow(alpha, 2));
                    wd = Math.Round(wd, 3);
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
                    C1 = Math.Round(C1, 3);
                    C2 = Math.Round(C2, 3);
                    result.Text = displayUnderDamped(Csol, -alpha,wd, C1, C2, final);

                }

            }
        }

        public void plotOverDamped(double s1, double s2, double c1, double c2, double final)
        {
            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();
            double TimeConstant = 1 / Math.Max(s1, s2);
            double step = 10e-6;
            for (double i = 0; i <= 5 * TimeConstant; i += step)
            {
                xValues.Add(i);
                double y = final + c1 * Math.Exp(s1 * i) + c2 * Math.Exp(s2 * i);
                yValues.Add(y);

            }
        }
        public void plotCriticallyDamped(double alpha, double c1, double c2, double final)
        {
            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();
            double TimeConstant = 1 / alpha;
            double step = 10e-6;
            for (double i = 0; i <= 5 * TimeConstant; i += step)
            {
                xValues.Add(i);
                double y = final + c1 * Math.Exp(alpha * i) + c2 * i * Math.Exp(alpha * i);
                yValues.Add(y);

            }
        }
        public void plotUnderDamped(double alpha, double wd, double c1, double c2, double final)
        {
            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();
            double TimeConstant = 1 / alpha;
            double step = 10e-6;
            for (double i = 0; i <= 5 * TimeConstant; i += step)
            {
                xValues.Add(i);
                double y = final + c1 * Math.Exp(alpha * i)* Math.Cos(i*wd)+ c2 * Math.Exp(alpha * i) * Math.Sin(i * wd);
                yValues.Add(y);
            }
        }
        string displayOverDamped(string Csol,double s1, double s2, double c1, double c2, double final)
        {
            string res  = Csol + " = ";

            if (final != 0)
                res += final ;

            if (c1 != 0)
            {
                if (final != 0 && c1 > 0)
                    res += "+";
                res += c1.ToString() + " e^" + s1 + "t ";

            }

            if (c2 != 0)
            {
                if (c1 != 0 && c2 > 0)
                    res += " + ";
                res +=  c2.ToString() + " e^" + s2 + "t ";

            }
            res += (Csol[0] == 'I') ? "A" : "V";
            return res;
        }
        string displayCriticallyDamped(string Csol, double naplha, double c1, double c2, double final)
        {
            string res = Csol + " = ";

            if (final != 0)
                res += final;

            if (c1 != 0)
            {
                if (final != 0 && c1 > 0)
                    res += "+";
                res += c1.ToString() + " e^" + naplha + "t ";

            }

            if (c2 != 0)
            {
                if (c1 != 0 && c2 > 0)
                    res += " + ";
                res += c2.ToString() + " t e^" + naplha + "t ";

            }
            res += (Csol[0] == 'I') ? "A" : "V";
            return res;
        }
        string displayUnderDamped(string Csol, double aplha,double wd, double c1, double c2, double final)
        {
            string res = Csol + " = ";

            if (final != 0)
                res += final;

            if (c1 != 0)
            {
                if (final != 0 && c1 > 0)
                    res += "+";
                res +=c1.ToString() + " e^" + -aplha + "t cos(" +wd +") ";

            }

            if (c2 != 0)
            {
                if (c1 != 0 && c2 > 0)
                    res += " + ";
                res += c2.ToString() + " e^" + -aplha + "t sin(" + wd + ") ";

            }
            res += (Csol[0] == 'I') ? "A" : "V";
            return res;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

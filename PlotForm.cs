using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CircuitsProject
{
    public partial class PlotForm : Form
    {
        public PlotForm()
        {
            InitializeComponent();
            Chart.ChartAreas[0].AxisX.Minimum = 0;
            foreach(var series in Chart.Series)
            {
                series.Points.Clear();
            }
            Chart.Annotations.Clear();
            Chart.Titles.Clear();

            Chart.AntiAliasing = AntiAliasingStyles.All;
        }

        public void PlotData(Data data,int index)
        {
            if(data.State == 0)
            {
                plotOverDamped(data.pow1, data.pow2, data.c1, data.c2, data.final,index);
                string text = displayOverDamped(data.Csol, data.pow1,data.pow2, data.c1, data.c2, data.final);
                SetTextForTextBoxByIndex(index, text);
            }
            if(data.State == 1)
            {
                plotCriticallyDamped(data.pow1, data.c1, data.c2, data.final,index);
                string text = displayCriticallyDamped(data.Csol, data.pow1, data.c1, data.c2, data.final);
                SetTextForTextBoxByIndex( index,  text);

            }
            if (data.State == 2) {
                plotUnderDamped(data.pow1,data.pow2, data.c1, data.c2, data.final,index);
                string text = displayUnderDamped(data.Csol, data.pow1, data.pow2, data.c1, data.c2, data.final);
                SetTextForTextBoxByIndex(index, text);

            }



        }
        public void plotOverDamped(double s1, double s2, double c1, double c2, double final,int index)
        {

            double TimeConstant = -1 / Math.Max(s1, s2);
            for (double i = 0; i <= 6 * TimeConstant; i += TimeConstant/100)
            {
                double y = final + c1 * Math.Exp(s1 * i) + c2 * Math.Exp(s2 * i);
                Chart.Series[index].Points.AddXY(i, y);
            }
        }
        public void plotCriticallyDamped(double alpha, double c1, double c2, double final,int index)
        {

            double TimeConstant = -1 / alpha;
            for (double i = 0; i <= 10 * TimeConstant; i += TimeConstant / 100)
            {
                double y = final + c1 * Math.Exp(alpha * i) + c2 * i * Math.Exp(alpha * i);
                Chart.Series[index].Points.AddXY(i, y);

            }
        }
        public void plotUnderDamped(double naplha, double wd, double c1, double c2, double final,int index)
        {

            double TimeConstant = -1 / naplha;
            for (double i = 0; i <= 10 * TimeConstant; i += TimeConstant / 100)
            {
                double y = final + c1 * Math.Exp(naplha * i) * Math.Cos(i * wd) + c2 * Math.Exp(naplha * i) * Math.Sin(i * wd);
                Chart.Series[index].Points.AddXY(i, y);

            }
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
        string displayUnderDamped(string Csol, double naplha, double wd, double c1, double c2, double final)
        {
            string res = Csol + " = ";

            if (final != 0)
                res += final;

            if (c1 != 0)
            {
                if (final != 0 && c1 > 0)
                    res += "+";
                res += c1.ToString() + " e^" + naplha + "t cos(" + wd + ") ";

            }

            if (c2 != 0)
            {
                if (c1 != 0 && c2 > 0)
                    res += " + ";
                res += c2.ToString() + " e^" + naplha + "t sin(" + wd + ") ";

            }
            res += (Csol[0] == 'I') ? "A" : "V";
            return res;
        }
        string displayOverDamped(string Csol, double s1, double s2, double c1, double c2, double final)
        {
            string res = Csol + " = ";

            if (final != 0)
                res += final;

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
                res += c2.ToString() + " e^" + s2 + "t ";

            }
            res += (Csol[0] == 'I') ? "A" : "V";
            return res;
        }
        private void PlotForm_Load(object sender, EventArgs e)
        {

        }
        private void SetTextForTextBoxByIndex(int index, string text)
        {
            // Find the TextBox control by index
            var textBoxes = this.Controls.OfType<TextBox>().ToList();
            if (index < textBoxes.Count)
            {
                textBoxes[index].Text = text;
            }
            else
            {
                MessageBox.Show("TextBox at index " + index + " does not exist.");
            }
        }

        private void Chart_Click(object sender, EventArgs e)
        {

        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

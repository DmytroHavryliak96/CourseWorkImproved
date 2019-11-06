using NeuralNetwork;
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

namespace CourseWork
{
    public partial class ErrorGraphForm : Form
    {
        private LVQErrorCollection lvq;
        private BPNErrorCollection bpn;

        public ErrorGraphForm(LVQErrorCollection _lvq, BPNErrorCollection _bpn)
        {

            InitializeComponent();

            lvq = _lvq;
            bpn = _bpn;

            this.chart1.ChartAreas[0].AxisX.Title = "ітерація";
            this.chart1.ChartAreas[0].AxisY.Title = "похибка";

            this.chart2.ChartAreas[0].AxisX.Title = "ітерація";
            this.chart2.ChartAreas[0].AxisY.Title = "похибка";

            DataBinding();
        }

        private void DataBinding()
        {
            if (bpn != null)
                Bind(bpn, this.chart1);
            if (lvq != null)
                Bind(lvq, this.chart2);

           
        }

        private void Bind(IErrorCollection collection, Chart chart)
        {
            var data = collection.GetCollection();

            foreach(var item in data)
                chart.Series[collection.Name].Points.AddXY(item.Key, item.Value);
            
        }


    }
}

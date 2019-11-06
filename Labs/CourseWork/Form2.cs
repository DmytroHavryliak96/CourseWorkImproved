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
        }

        private void DataBinding()
        {
            if (bpn != null)
                Bind(bpn);
            if (lvq != null)
                Bind(lvq);

           
        }

        private void Bind(IErrorCollection collection)
        {
            var data = collection.GetCollection();

            foreach(var item in data)
                this.chart1.Series[collection.Name].Points.AddXY(item.Key, item.Value);
            
        }


    }
}

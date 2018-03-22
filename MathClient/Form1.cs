using MathClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathClient
{
    public partial class Form1 : Form
    {
        MathsOperationsClient clientDefault;
        MathsOperationsClient clientAnotherPort;
        MathsOperationsClient clientAnotherAddress;

        public Form1()
        {
            InitializeComponent();
            clientDefault = new MathsOperationsClient("Default");
            clientAnotherPort = new MathsOperationsClient("AnotherPort");
            clientAnotherAddress = new MathsOperationsClient("AnotherAddress");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = clientDefault.Add(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString() + " (from: " + clientDefault.Endpoint.Address + ")";
            label2.Text = clientAnotherPort.Add(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString() + " (from: " + clientAnotherPort.Endpoint.Address + ")";
            label3.Text = clientAnotherAddress.Add(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString() + " (from: " + clientAnotherAddress.Endpoint.Address + ")";

        }
    }
}

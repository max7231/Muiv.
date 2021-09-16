using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Messenger : Form
    {
        private Engine _engine;
        public Messenger(Engine engine)
        {
            _engine = engine;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(textBox1.Text);
            _engine.SendMessage(textBox1.Text);
            richTextBox2.Text = richTextBox2.Text + "\n" + textBox1.Text;
            textBox1.Text = "";
        }

    }
}

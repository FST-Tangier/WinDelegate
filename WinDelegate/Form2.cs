using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDelegate
{
    public partial class Form2 : Form
    {
        public delegate void txtHandler(string msg);
        public event txtHandler msgChanged;

        public Form2()
        {
            InitializeComponent();
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {
           msgChanged(txtMsg.Text);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

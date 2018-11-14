/*
 * Cameron Kennedy
 * ITSE 1430
 * Lab 4
 * 11/13/2018 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OnOkClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

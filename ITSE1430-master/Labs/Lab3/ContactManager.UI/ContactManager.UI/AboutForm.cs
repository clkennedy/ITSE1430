﻿/*
 * Author : Cameron Kennedy
 * ITSE 1430
 * 9/20/2018 
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

namespace ContactManager.UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OnOkClick( object sender, EventArgs e )
        {
            Close();
        }

        private void OnFormLoad( object sender, EventArgs e )
        {
            AcceptButton = okButton;
        }
    }
}

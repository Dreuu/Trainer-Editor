﻿using System.Windows.Forms;

namespace Hopeless
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            label1.Left = (ClientSize.Width - label1.Width) / 2;
            label2.Left = (ClientSize.Width - label2.Width) / 2;
            label3.Left = (ClientSize.Width - label3.Width) / 2;
            label4.Left = (ClientSize.Width - label4.Width) / 2;
        }
    }
}

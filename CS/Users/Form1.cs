﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Users.Reports;
using DevExpress.XtraReports.UI;

namespace Users
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UserItemReport report = new UserItemReport();
            report.CreateDocument();
            report.ShowPreviewDialog();
        }
    }
}

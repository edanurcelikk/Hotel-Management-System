﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class admin_customers : UserControl
    {
        public admin_customers()
        {
            InitializeComponent();
            displayCustomers();
        }
        public void refreshData(){
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomers();
        }



        public void displayCustomers()
        {
            customersData cdata = new customersData();
            List<customersData> listData = cdata.customersListData();

            dataGridView1.DataSource = listData;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagement.Forms
{
    public partial class Admindashboard : Form
    {
        public Admindashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Admindashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new dashboard());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new studentdashboard());
        }


        private Form activeform = null;
        public void OpenChildForm(Form childform)
        {

           if(activeform != null)
                 activeform = null;
           activeform = childform;
           childform.TopLevel = false;
           childform.FormBorderStyle = FormBorderStyle.None;
           childform.Dock = DockStyle.Fill;
           panel3.Controls.Add(childform);
           childform.BringToFront();
           childform.Show(); 


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

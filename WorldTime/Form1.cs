//////////////////////////////////////
// Copyright Charlie Kingsland 2021 //
//////// Do not distribute ///////////
//////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldTime
{
    public partial class Form1 : Form
    {

        Timer t = new Timer();

        //TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        //TimeZoneInfo pacificZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        //TimeZoneInfo indianZone = TimeZoneInfo.FindSystemTimeZoneById("Indian Standard Time");

        bool top = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.TopMost = top;
            //Console.WriteLine(this.TopMost());

            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();

            
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //int hh = DateTime.Now.AddMinutes(10).Hour;
            //int mm = DateTime.Now.Minute;

            DateTime now = DateTime.Now;
            DateTime istZone = DateTime.Now.AddMilliseconds(19800000);
            DateTime estZone = DateTime.Now.AddMilliseconds(-18000000);
            DateTime pstZone = DateTime.Now.AddMilliseconds(-28800000);


            localLbl.Text = formatDT(now.Hour, now.Minute);
            pst.Text = formatDT(pstZone.Hour, pstZone.Minute);
            est.Text = formatDT(estZone.Hour, estZone.Minute);
            ist.Text = formatDT(istZone.Hour, istZone.Minute);
        }

        private static string formatDT(int hh, int mm)
        {
            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            return time;
        }

        private void localLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ontop_Click(object sender, EventArgs e)
        {
            top = !top;
            this.TopMost = top;
        }
    }
}

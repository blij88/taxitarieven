using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal dist;
        DateTime depart, arrive;
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

 

        private void departure_ValueChanged(object sender, EventArgs e)
        {
        }

        private void arrival_ValueChanged(object sender, EventArgs e)
        {
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            dist = distance.Value;
            depart = departure.Value;
            arrive = arrival.Value;
            decimal kmPrice = GetPrice(dist);
            decimal time = RideTime(depart, arrive);
            decimal timePrice =
        }

        private void distance_ValueChanged(object sender, EventArgs e)
        {

        }

        public decimal GetPrice(decimal dist)
        {
            decimal tariff = 1;
            decimal kmPrice = dist * tariff;
            return kmPrice;
        }

        public decimal RideTime(DateTime depart, DateTime arrive)
        {
            TimeSpan lengthOfRide = arrive.Subtract(depart);
            Double lengthInMin = lengthOfRide.TotalMinutes;
            decimal length = (decimal)lengthInMin;
            return length;
        }
    }
}

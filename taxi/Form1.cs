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
            int dist = (int)distance.Value;
            DateTime departTot = departure.Value;
            depart = departTot.AddSeconds(-departTot.Second);
            DateTime arriveTot = arrival.Value;
            arrive = arriveTot.AddSeconds(-arriveTot.Second);

            decimal kmPrice = GetPrice(dist);
            decimal rideprice = RideTime(depart, arrive);
            bool isWeekend = IsWeekend(depart);
            if (isWeekend == true)
            {
                string Total = ((kmPrice + rideprice) * (decimal)1.15).ToString("F");
                textBox1.Text += "gereden kilometers: " + dist.ToString() +"\r\nTotaal = €"+Total;
            }
            else
            {
                string Total = ((double)(kmPrice + rideprice)).ToString("F");
                textBox1.Text += "\r\ngereden kilometers: " + dist.ToString() + "\r\nTotaal = €" + Total;
            }
            
        }

        private void distance_ValueChanged(object sender, EventArgs e)
        {

        }

        public decimal GetPrice(decimal dist)
        {
            decimal kmTariff = (decimal)1.00;
            decimal kmPrice = dist * kmTariff;
            return kmPrice;
        }

        public decimal RideTime(DateTime depart, DateTime arrive)
        {
            decimal before8 = 0;
            decimal after6 = 0;
            decimal outTariff = (decimal)0.45;
            decimal inTariff = (decimal)0.25;
            // get time to 8
            if (depart.Hour<8)
            {
                var it8 = new TimeSpan(8,0,0);
                before8 = (int)it8.Subtract(depart.TimeOfDay).TotalMinutes;
            }
            // get time after 18
            if (arrive.Hour>=18)
            {
                var it6 = new TimeSpan(18, 0, 0);
                after6 = (int)arrive.TimeOfDay.Subtract(it6).TotalMinutes;
            }
            //get total time subtract time before and or after 8 and 18
            decimal totalTimeOut = before8 + after6;
            decimal outPrice = totalTimeOut * outTariff;           
            decimal rideLength = (decimal)arrive.Subtract(depart).TotalMinutes;
            decimal timeIn = rideLength - totalTimeOut;
            decimal inPrice = timeIn * inTariff;
            decimal totalTimePrice = inPrice + outPrice;
            textBox1.Text = "totale ritduur in minuten: " + rideLength.ToString("F");
            textBox1.Text += "\r\nminuten buiten de daluren: " + totalTimeOut.ToString("F") + "\r\nprijs = " + outPrice.ToString();
            textBox1.Text += "\r\nminuten binnen daluren = " + timeIn.ToString("F")+ "\r\nPrijs = " + inPrice  ;
            return totalTimePrice;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            departure.Value = DateTime.Now;
            arrival.Value = DateTime.Now;
        }

        public bool IsWeekend(DateTime depart)
        {
            bool weekend = false;
            int Day = (int)depart.DayOfWeek;
            int hour = depart.Hour;
            if ((Day == 1) && (hour<7))
            {
                weekend = true;
            }
            else if((Day == 5) && (hour>21))
            {
                weekend = true;
            }
            else if((Day == 6)||(Day == 7))
            {
                weekend = true;
            }

            return weekend ;

        }

    }
}

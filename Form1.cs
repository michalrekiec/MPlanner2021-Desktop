using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp2021
{
    public partial class MainWindow : Form
    {
        public List<SingleEvent> listOfEvents = new List<SingleEvent>();
        public MainWindow()
        {
            InitializeComponent();
        }

        // Exit application method
        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitApp();
        }
        private void ExitApp()
        {
            DialogResult exitapp;
            exitapp = MessageBox.Show("Do you want to exit?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (exitapp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Delete single event from planner
        private void delButton_Click(object sender, EventArgs e)
        {
            deleteItem();
        }

        private void deleteItem()
        {
            foreach (DataGridViewRow element in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(element.Index);
            }
        }

        // Adding information about new event - description, date and time of event and addition
        private void addButton_Click(object sender, EventArgs e)
        {
            string datetimeText;
            string additionDate;
            DateTime timeDet;
            //Int64 idNumber;

            //var eventTime = new DateTime();

            if ((Convert.ToByte(hourBox.Text) < 0) || (Convert.ToByte(hourBox.Text) > 23) || (Convert.ToByte(minuteBox.Text) < 0) || (Convert.ToByte(minuteBox.Text) > 59))
            {
                warningLabel.Text = String.Format("Please type correct value of time.");
            }
            else
            {
                datetimeText = String.Format("{0,2:D2}.{1,2:D2}.{2} {3,2:D2}:{4,2:D2}", dateTimePicker1.Value.Day, dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Year, Convert.ToByte(hourBox.Text), Convert.ToByte(minuteBox.Text));

                additionDate = String.Format("{0,2:D2}.{1,2:D2}.{2} {3,2:D2}:{4,2:D2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year,
                    DateTime.Now.Hour, DateTime.Now.Minute);

                dataGridView1.Rows.Add(nameBox.Text, descriptionBox.Text, datetimeText, additionDate);
                warningLabel.Text = String.Format("");

                timeDet = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, Convert.ToByte(hourBox.Text), Convert.ToByte(minuteBox.Text), 0);

                listOfEvents.Add(new SingleEvent { EventName = nameBox.Text, Description = descriptionBox.Text, TimeDetails = timeDet, EventID = ConvertToID() });
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = String.Format("{0, 2:D2}:{1, 2:D2}:{2, 2:D2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            dateLabel.Text = String.Format("{0, 2:D2}.{1, 2:D2}.{2}, {3}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.DayOfWeek);
        }

        // Function creating unique ID number for every single event. To minimise risk of numbers collision each ID has got random two digits at the end.
        private Int64 ConvertToID()
        {
            Int64 result;
            Random rnd = new Random();
            int num = rnd.Next(1, 101);

            result = (DateTime.Now.Year % 100) * 1000000000000 + DateTime.Now.Month * 10000000000 + Convert.ToInt64(DateTime.Now.Day) * 100000000
                + DateTime.Now.Hour * 1000000 + DateTime.Now.Minute * 10000 + DateTime.Now.Second * 100 + num % 100;

            return result;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
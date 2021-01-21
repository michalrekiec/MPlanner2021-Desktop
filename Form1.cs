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
        public MainWindow()
        {
            InitializeComponent();
        }

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

        private void addButton_Click(object sender, EventArgs e)
        {
            string datetimeText;
            var eventTime = new DateTime();

            datetimeText = String.Format("{0,2:D2}.{1,2:D2}.{2} {3,2:D2}:{4,2:D2}", dateTimePicker1.Value.Day, dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Year, Convert.ToByte(hourBox.Text), Convert.ToByte(minuteBox.Text));

            dataGridView1.Rows.Add(descriptionBox.Text, datetimeText);
        }
    }
}

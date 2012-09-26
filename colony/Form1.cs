using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace colony
{
    public partial class Form1 : Form
    {
        private int dayLength;
        private bool dayLengthChanged;
        private int timer;
        private Colony colony;

        public Form1()
        {
            InitializeComponent();
            timer = 0;
            dayLength = 5;
            dayLengthChanged = false;
            colony = new Colony();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = colony.Name;

            progressBar1.Maximum = dayLength;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            UpdateResources();
        }

        /// <summary>
        /// Update display value of resources as well as their rate on tooltip
        /// </summary>
        private void UpdateResources()
        {
            metalStt.Text = colony.eco.Metal.ToString();
            if (colony.eco.Metal.IsFull)
                metalStt.ForeColor = Color.Red;

            crystalStt.Text = colony.eco.Crystal.ToString();
            if (colony.eco.Crystal.IsFull)
                crystalStt.ForeColor = Color.Red;

            energyStt.Text = colony.eco.Energy.ToString();
            if (colony.eco.Energy.IsFull)
                energyStt.ForeColor = Color.Red;

            toolTip1.SetToolTip(metalStt, colony.eco.Metal.Tooltip);
            toolTip1.SetToolTip(crystalStt, colony.eco.Crystal.Tooltip);
            toolTip1.SetToolTip(energyStt, colony.eco.Energy.Tooltip);
            toolTip1.SetToolTip(progressBar1, String.Format("{0}s a day", dayLength));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            progressBar1.PerformStep();
            if (timer > progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                timer = 0;
                dayTick();
            }
        }

        private void dayTick()
        {
            colony.eco.Tick();
            UpdateResources();

            if (dayLengthChanged)
            {
                dayLengthChanged = false;
                progressBar1.Maximum = dayLength;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizykaObrazu
{
    public partial class Form2 : Form
    {
        public double cannyTreshold;
        public double minDist;
        public double param1;
        public double param2;
        public int minRadius;
        public int maxRadius;
        public double rho;
        public double theta;
        public int treshold;
        public double minLineWidth;
        public double maxGap;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void minDistTrackBar_Scroll(object sender, EventArgs e)
        {
            minDist = minDistTrackBar.Value;
            minDistTextBox.Text = minDistTrackBar.Value.ToString();
        }

        private void param1TrackBar_Scroll(object sender, EventArgs e)
        {
            param1 = param1TrackBar.Value;
            param1TextBox.Text = param1TrackBar.Value.ToString();
        }

        private void param2TrackBar_Scroll(object sender, EventArgs e)
        {
            param2 = param2TrackBar.Value;
            param2TextBox.Text = param2TrackBar.Value.ToString();
        }

        private void minRadiusTrackBar_Scroll(object sender, EventArgs e)
        {
            minRadius = minRadiusTrackBar.Value;
            minRadiusTextBox.Text = minRadiusTrackBar.Value.ToString();
        }

        private void maxRadiusTrackBar_Scroll(object sender, EventArgs e)
        {
            maxRadius = maxRadiusTrackBar.Value;
            maxRadiusTextBox.Text = maxRadiusTrackBar.Value.ToString();
        }

       

        private void distanceTrackBar_Scroll(object sender, EventArgs e)
        {
            rho = distanceTrackBar.Value/10;
            distanceTextBox.Text = distanceTrackBar.Value.ToString();
        }

        private void angleTrackBar_Scroll(object sender, EventArgs e)
        {
            theta = angleTrackBar.Value;
            angleTextBox.Text = angleTrackBar.Value.ToString();
        }

        private void tresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            treshold = tresholdTrackBar.Value;
            tresholdTextBox.Text = tresholdTrackBar.Value.ToString();
        }

        private void minWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            minLineWidth = minWidthTrackBar.Value;
            minWidthTextBox.Text = minWidthTrackBar.Value.ToString();
        }

        private void gapTrackBar_Scroll(object sender, EventArgs e)
        {
            maxGap = gapTrackBar.Value;
            gapTextBox.Text = gapTrackBar.Value.ToString();
        }

        private void houghTransfrom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
